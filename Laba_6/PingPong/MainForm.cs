using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace PingPong
{
	public partial class MainForm : Form
	{
		private const float Pi = (float)Math.PI;
		private const float _2pi = Pi * 2;

		private Board _board;
		private static readonly Ball s_nullBall = new NullBall();
		private static readonly CellPoint s_voidPoint = new VoidPoint();
		private static readonly CellPoint s_wallPoint = new WallPoint();
		private static readonly Random s_random = new();

		private class Vector
		{
			public Vector(float x, float y)
			{
				X = x;
				Y = y;
			}

			public static Vector operator +(Vector a, Vector b)
			{
				return new Vector(a.X + b.X, a.Y + b.Y);
			}

			public static Vector operator -(Vector a, Vector b)
			{
				return new Vector(a.X - b.X, a.Y - b.Y);
			}

			public static float operator *(Vector a, Vector b)
			{
				return a.X * b.X + a.Y * b.Y;
			}

			public static Vector operator *(Vector a, float b)
			{
				return new Vector(a.X * b, a.Y * b);
			}

			public static Vector operator *(float b, Vector a)
			{
				return new Vector(a.X * b, a.Y * b);
			}

			public static Vector operator /(Vector a, float b)
			{
				return new Vector(a.X / b, a.Y / b);
			}

			public float X { get; }
			public float Y { get; }
		}

		private abstract class Ball
		{
			public abstract void BeginMove();
			public abstract void StopMove();
			public abstract void StartMove();
			public abstract void Draw(Graphics graphics);
			public abstract void Move();
			public abstract void Move(CellPoint[,] cellPoints, PictureBox picture, Board board);
			public abstract void Reflection(float xx, float yy);
			public abstract void TouchPoint(CellPoint[,] cellPoints, Board board, float phi);
			public abstract void Stop(Platform platform, int idPlayer);
			public abstract float Angle { get; set; }
			public abstract float X { get; set; }
			public abstract float Y { get; set; }
			public abstract float Radius { get; set; }
			public abstract float Velocity { get; set; }
		}

		private class RealBall : Ball
		{
			private float _radius;
			private float _diameter;
			private float _velocity;
			private float _x;
			private float _y;
			private float _directionX;
			private float _directionY;
			private float _alpha;
			private const float DeltaPhi = (float)Math.PI / 20;

			private Vector _vector;
			private readonly Timer _timer;

			public RealBall(EventHandler tick, float radius, float velocity, float x, float y, float alpha)
			{
				_radius = radius;
				_velocity = velocity;
				_x = x;
				_y = y;
				_alpha = alpha;

				_timer = new Timer();
				_timer.Tick += tick;

				_directionX = (float)Math.Cos(alpha);
				_directionY = (float)Math.Sin(alpha);

				_vector = new Vector(_directionX, _directionY);

				_diameter = 2 * radius;
			}

			public override void BeginMove()
			{
				_timer.Enabled = true;
				_timer.Interval = 1;
				StartMove();
			}

			public override void StopMove()
			{
				_timer.Enabled = false;
			}

			public override void StartMove()
			{
				_directionX = (float)Math.Cos(_alpha);
				_directionY = (float)Math.Sin(_alpha);

				_vector = new Vector(_directionX, _directionY);
			}

			public override void Draw(Graphics graphics)
			{
				graphics.FillEllipse(Brushes.White, _x - _radius, _y - _radius, _diameter, _diameter);
			}

			public override void Move()
			{
				_x += _directionX / 10;
				_y += _directionY / 10;
			}

			public override void Move(CellPoint[,] cellPoints, PictureBox picture, Board board)
			{
				for (int i = 0; i < 10 * _velocity; i++)
					TouchPoint(cellPoints, board, 0);

				picture.Invalidate();
			}

			public override void Reflection(float xx, float yy)
			{
				Vector oh = new(xx - _x, yy - _y);

				if (oh * _vector >= 0)
				{
					float lambda = - (_vector * oh) / (oh * oh);
					Vector h = _vector + lambda * oh;
					_vector = h + lambda * oh;
					_directionX = _vector.X;
					_directionY = _vector.Y;
				}
			}

			public override void TouchPoint(CellPoint[,] cellPoints, Board board, float phi)
			{
				float xx = _radius * (float)Math.Cos(phi) + _x;
				float yy = _radius * (float)Math.Sin(phi) + _y;

				cellPoints[(int)xx, (int)yy].Touch(this, cellPoints, board, xx, yy, phi, DeltaPhi);
			}

			public override void Stop(Platform platform, int idPlayer)
			{
				_directionX = 0;
				_directionY = 0;
				_vector = new Vector(0, 0);
				_y = platform.Y;
				_x = platform.X + (1 - 2 * idPlayer) * (platform.Width / 2 + _radius);
				platform.CurrentBall = this;
			}

			public override float Angle { get => _alpha; set { _alpha = value; } }
			public override float X { get => _x; set { _x = value; } }
			public override float Y { get => _y; set { _y = value; } }
			public override float Radius { get => _radius; set { _radius = value; _diameter = 2 * _radius; } }
			public override float Velocity { get => _velocity; set { _velocity = value; } }
		}

		private class NullBall : Ball
		{
			public override void BeginMove() { }
			public override void StopMove() { }
			public override void StartMove() { }
			public override void Draw(Graphics graphics) { }
			public override void Move() { }
			public override void Move(CellPoint[,] cellPoints, PictureBox picture, Board board) { }
			public override void Reflection(float xx, float yy) { }
			public override void TouchPoint(CellPoint[,] cellPoints, Board board, float phi) { }
			public override void Stop(Platform platform, int idPlayer) { }
			public override float Angle { get => 0; set { } }
			public override float X { get => 0; set { } }
			public override float Y { get => 0; set { } }
			public override float Radius { get => 0; set { } }
			public override float Velocity { get => 0; set { } }
		}

		private abstract class CellPoint
		{
			public abstract void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaPhi);
		}

		private class VoidPoint : CellPoint
		{
			private delegate void Del(Ball ball, CellPoint[,] cellPoints, Board board, float phi, float deltaPhi);
			private readonly Del[] _delArray = { Move, NextPoint };

			public override void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaPhi)
			{
				_delArray[(phi <= _2pi).GetHashCode()](ball, cellPoints, board, phi, deltaPhi);
			}

			private static void NextPoint(Ball ball, CellPoint[,] cellPoints, Board board, float phi, float deltaPhi)
			{
				ball.TouchPoint(cellPoints, board, phi + deltaPhi);
			}

			private static void Move(Ball ball, CellPoint[,] cellPoints, Board board, float phi, float deltaPhi)
			{
				ball.Move();
			}
		}

		private class WallPoint : CellPoint
		{
			private delegate void Del(Ball ball, float phi, float xx, float yy);
			private Del[] _delArray = { Stop, Reflection };

			public override void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaPhi)
			{
				ball.Reflection(xx, yy);
				ball.Move();
			}

			private static void Stop(Ball ball, float phi, float xx, float yy) { }

			private static void Reflection(Ball ball, float phi, float xx, float yy)
			{
				ball.Reflection(xx, yy);
				ball.Move();
			}
		}

		private class GatePoint : CellPoint
		{
			private readonly Player _player;

			public GatePoint(Player player)
			{
				_player = player;
			}

			public override void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaPhi)
			{
				_player.Score++;

				ball.Stop(_player.Platform, _player.Id);
				board.ShowScore();
			}
		}

		private class Platform
		{
			private readonly Timer _timer;

			public Platform(CellPoint[,] cellPoints, EventHandler tick, float width, float height, float x, float y)
			{
				X = x;
				Y = y;
				Width = width;
				Height = height;

				_timer = new Timer();
				_timer.Tick += tick;

				FillPoints(cellPoints);
				CurrentBall = s_nullBall;
			}

			private void FillPoints(CellPoint[,] cellPoints)
			{
				for (int i = 0, xx = (int)(X - Width / 2); i < Width; i++, xx++)
				{
					for (int j = 0, yy = (int)(Y - Height / 2); j < Height; j++, yy++)
					{
						cellPoints[xx, yy] = s_wallPoint;
					}
				}
			}

			private void ClearPoints(CellPoint[,] cellPoints)
			{
				for (int i = 0, xx = (int)(X - Width / 2); i < Width; i++, xx++)
				{
					for (int j = 0, yy = (int)(Y - Height / 2); j < Height; j++, yy++)
					{
						cellPoints[xx, yy] = s_voidPoint;
					}
				}
			}

			public void Draw(Graphics graphics)
			{
				graphics.FillRectangle(Brushes.White, X - Width / 2, Y - Height / 2, Width, Height);
			}

			public void Move(CellPoint[,] cellPoints, float h)
			{
				ClearPoints(cellPoints);

				for (int i = 0; i < 10; i++)
				{
					if (Y > Height / 2 + 1 + 10 && Destination < Y || Y < h - Height / 2 - 2 - 10 && Destination > Y)
					{
						Y += Math.Sign(Destination - Y);
					}
				}

				CurrentBall.Y = Y;

				FillPoints(cellPoints);
			}

			public void StartMove(float h)
			{
				Y = h / 2;
				_timer.Enabled = true;
				_timer.Interval = 1;
				Destination = Y;
				CurrentBall = s_nullBall;
			}

			public void StopMove()
			{
				_timer.Enabled = false;
			}

			public float X { get; }
			public float Y { get; private set; }
			public float Width { get; }
			public float Height { get; set; }
			public float Destination { get; set; }
			public Ball CurrentBall { get; set; }
		}

		private class Player
		{
			public Player(Platform platform, int id)
			{
				Id = id;
				Platform = platform;
			}

			public void MovingPlatform(CellPoint[,] cellPoints, float height)
			{
				Platform.Move(cellPoints, height);
			}

			public void MovePlatform(float y)
			{
				Platform.Destination = y;
			}

			public void DrawPlatform(Graphics graphics)
			{
				Platform.Draw(graphics);
			}

			public void Start(float h)
			{
				Score = 0;
				Platform.StartMove(h);
			}

			public void Stop()
			{
				Platform.StopMove();
			}

			public void StartBall()
			{
				Platform.CurrentBall.Angle = Id * Pi + (Pi / 2 * s_random.Next() - Pi / 4);
				Platform.CurrentBall.StartMove();
				Platform.CurrentBall = s_nullBall;
			}

			public float Y => Platform.Y;
			public int Id { get; }
			public int Score { get; set; }
			public Platform Platform { get; }
		}

		public class Board
		{
			private readonly float _width;
			private readonly float _height;

			private readonly Ball _ball;
			private readonly PictureBox _picture;
			private readonly Label _score;
			private readonly TrackBar _trackVelocity;
			private readonly TrackBar _trackPlatformSize;
			private readonly TrackBar _trackBallSize;

			private readonly CellPoint[,] _points;
			private readonly Player[] _players = new Player[2];

			public Board(PictureBox picture, Label score, TrackBar trackVelocity, TrackBar trackPlatformSize, TrackBar trackBallSize, int width, int height)
			{
				_width = width;
				_height = height;
				_picture = picture;
				_score = score;
				_trackVelocity = trackVelocity;
				_trackPlatformSize = trackPlatformSize;
				_trackBallSize = trackBallSize;

				_points = new CellPoint[width, height];

				for (int x = 0; x < width; x++)
					for (int y = 0; y < height; y++)
						_points[x, y] = s_wallPoint;

				for (int x = 10; x < width - 10; x++)
					for (int y = 10; y < height - 10; y++)
						_points[x, y] = s_voidPoint;

				_ball = new RealBall(TickBall, trackBallSize.Value, trackVelocity.Value, _width / 2, _height / 2, 0);

				_players[0] = new Player(new Platform(_points, TickLeftPlatform, 15, trackPlatformSize.Value, 0.055F * width, _width / 2), 0);
				_players[1] = new Player(new Platform(_points, TickRightPlatform, 15, trackPlatformSize.Value, 0.945F * width, _height / 2), 1);

				GatePoint gate1 = new(_players[0]);
				GatePoint gate2 = new(_players[1]);

				for (int x = 0; x < 10; x++)
					for (int y = 10; y < height - 1; y++)
						_points[x, y] = gate1;

				for (int x = width - 10; x < width; x++)
					for (int y = 10; y < height - 1; y++)
						_points[x, y] = gate2;

				_picture.Paint += Paint;
				_picture.MouseMove += MouseMove;
				_picture.Click += Click;

				trackVelocity.Scroll += ScrollVelocity;
				trackPlatformSize.Scroll += ScrollPlatformSize;
				trackBallSize.Scroll += ScrollBallSize;
			}

			public void NewGame()
			{
				float alpha = _2pi * (float)s_random.NextDouble();

				_ball.X = _width / 2;
				_ball.Y = _height / 2;
				_ball.Angle = alpha;

				_ball.BeginMove();

				foreach (Player player in _players)
					player.Start(_height);

				ShowScore();

				_trackVelocity.Enabled = false;
				_trackPlatformSize.Enabled = false;
				_trackBallSize.Enabled = false;
			}

			public void StopGame()
			{
				_ball.StopMove();

				foreach (Player player in _players)
					player.Stop();

				_trackVelocity.Enabled = true;
				_trackPlatformSize.Enabled = true;
				_trackBallSize.Enabled = true;
			}

			public void ShowScore()
			{
				_score.Text = _players[1].Score + " – " + _players[0].Score;
			}

			private void TickBall(object sender, EventArgs e)
			{
				_ball.Move(_points, _picture, this);
			}

			private void Paint(object sender, PaintEventArgs e)
			{
				Graphics graphics = e.Graphics;

				_ball.Draw(graphics);

				foreach (Player player in _players)
					player.DrawPlatform(graphics);
			}

			private void MouseMove(object sender, MouseEventArgs e)
			{
				_players[1].MovePlatform(e.Y);
			}

			private void Click(object sender, EventArgs e)
			{
				_players[1].StartBall();
			}

			private void ScrollVelocity(object sender, EventArgs e)
			{
				_ball.Velocity = _trackVelocity.Value;
			}

			private void ScrollPlatformSize(object sender, EventArgs e)
			{
				foreach (Player player in _players)
					player.Platform.Height = _trackPlatformSize.Value;

				_picture.Invalidate();
			}

			private void ScrollBallSize(object sender, EventArgs e)
			{
				_ball.Radius = _trackBallSize.Value;
				_picture.Invalidate();
			}

			private void TickLeftPlatform(object sender, EventArgs e)
			{
				_players[1].MovingPlatform(_points, _height);
				_picture.Invalidate();
			}

			private void TickRightPlatform(object sender, EventArgs e)
			{

				if (Keyboard.IsKeyDown(Key.W))
					_players[0].MovePlatform(_players[0].Y - 5);

				if (Keyboard.IsKeyDown(Key.S))
					_players[0].MovePlatform(_players[0].Y + 5);

				if (Keyboard.IsKeyDown(Key.Space))
					_players[0].StartBall();

				_players[0].MovingPlatform(_points, _height);
				_picture.Invalidate();
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_board = new Board(pictureBox, lblScore, tbBallSpeed, tbPlatformSize, tbBallSize, pictureBox.Width, pictureBox.Height);
		}

		private void tsmNewGame_Click(object sender, EventArgs e)
		{
			_board.NewGame();
		}

		private void tsmEndGame_Click(object sender, EventArgs e)
		{
			_board.StopGame();
		}

		private void tsmExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tsmGameInfo_Click(object sender, EventArgs e)
		{
			GameInfo gameInfo = new();
			gameInfo.ShowDialog();
		}
	}
}
