using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace PingPong
{
	public partial class MainForm : Form
	{
		private const float _pi = (float)Math.PI;
		private const float _2pi = _pi * 2;

		private Board _board;
		private static Ball _nullBall = new NullBall();
		private static CellPoint _voidPoint = new VoidPoint();
		private static CellPoint _wallPoint = new WallPoint();
		private static GatePoint _gate1;
		private static GatePoint _gate2;
		private static Random _random = new Random();

		private class Vector
		{
			private float _x;
			private float _y;

			public Vector(float x, float y)
			{
				_x = x;
				_y = y;
			}

			public static Vector operator +(Vector a, Vector b)
			{
				return new Vector(a._x + b._x, a._y + b._y);
			}

			public static Vector operator -(Vector a, Vector b)
			{
				return new Vector(a._x - b._x, a._y - b._y);
			}

			public static float operator *(Vector a, Vector b)
			{
				return a._x * b._x + a._y * b._y;
			}

			public static Vector operator *(Vector a, float b)
			{
				return new Vector(a._x * b, a._y * b);
			}

			public static Vector operator *(float b, Vector a)
			{
				return new Vector(a._x * b, a._y * b);
			}

			public static Vector operator /(Vector a, float b)
			{
				return new Vector(a._x / b, a._y / b);
			}

			public float X => _x;
			public float Y => _y;
		}

		private abstract class Ball
		{
			public abstract void BeginMove();
			public abstract void StopMove();
			public abstract void StartMove();
			public abstract void Draw(Graphics graphics);
			public abstract void Move();
			public abstract void Move(CellPoint[,] cellPoints, PictureBox picture, Board board);
			public abstract void Reflection(float phi, float xx, float yy);
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
			private float _radius, _diametr;
			private float _velocity;
			private float _x, _y;
			private float _directionX, _directionY, _alpha;
			private float _deltaPhi = (float)Math.PI / 20;

			private Vector _vector;
			private Timer _timer;

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

				_diametr = 2 * radius;
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
				graphics.FillEllipse(Brushes.White, _x - _radius, _y - _radius, _diametr, _diametr);
			}

			public override void Move()
			{
				_x += (_directionX / 10);
				_y += (_directionY / 10);
			}

			public override void Move(CellPoint[,] cellPoints, PictureBox picture, Board board)
			{
				for (int i = 0; i < 10 * _velocity; i++)
				{
					TouchPoint(cellPoints, board, 0);
				}

				picture.Invalidate();
			}

			public override void Reflection(float phi, float xx, float yy)
			{
				Vector OH = new Vector(xx - _x, yy - _y);

				if (OH * _vector >= 0)
				{
					float lambda = - (_vector * OH) / (OH * OH);
					Vector h = _vector + lambda * OH;
					_vector = h + lambda * OH;
					_directionX = _vector.X;
					_directionY = _vector.Y;
				}
			}

			public override void TouchPoint(CellPoint[,] cellPoints, Board board, float phi)
			{
				float xx = _radius * (float)Math.Cos(phi) + _x;
				float yy = _radius * (float)Math.Sin(phi) + _y;

				cellPoints[(int)xx, (int)yy].Touch(this, cellPoints, board, xx, yy, phi, _deltaPhi);
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
			public override float Radius { get => _radius; set { _radius = value; _diametr = 2 * _radius; } }
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
			public override void Reflection(float phi, float xx, float yy) { }
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
			public abstract void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaphi);
		}

		private class VoidPoint : CellPoint
		{
			delegate void Del(Ball ball, CellPoint[,] cellPoints, Board board, float phi, float deltaphi);
			Del[] _delArray = new Del[] { Move, NextPoint };

			public override void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaphi)
			{
				_delArray[(phi <= _2pi).GetHashCode()](ball, cellPoints, board, phi, deltaphi);
			}

			private static void NextPoint(Ball ball, CellPoint[,] cellPoints, Board board, float phi, float deltaphi)
			{
				ball.TouchPoint(cellPoints, board, phi + deltaphi);
			}

			private static void Move(Ball ball, CellPoint[,] cellPoints, Board board, float phi, float deltaphi)
			{
				ball.Move();
			}
		}

		private class WallPoint : CellPoint
		{
			delegate void Del(Ball ball, float phi, float xx, float yy);
			Del[] _delArray = new Del[] { Stop, Reflection };

			public override void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaphi)
			{
				ball.Reflection(phi, xx, yy);
				ball.Move();
			}

			private static void Stop(Ball ball, float phi, float xx, float yy) { }

			private static void Reflection(Ball ball, float phi, float xx, float yy)
			{
				ball.Reflection(phi, xx, yy);
				ball.Move();
			}
		}

		private class GatePoint : CellPoint
		{
			private Player _player;

			public GatePoint(Player player)
			{
				_player = player;
			}

			public override void Touch(Ball ball, CellPoint[,] cellPoints, Board board, float xx, float yy, float phi, float deltaphi)
			{
				_player.Score++;

				ball.Stop(_player.Platform, _player.ID);
				board.ShowScore();
			}
		}

		private class Platform
		{
			private float _width;
			private float _height;
			private float _x;
			private float _y;
			private float _destination;

			private Timer _timer;
			private Ball _currentBall;

			public Platform(CellPoint[,] cellPoints, EventHandler tick, float width, float height, float x, float y)
			{
				_x = x;
				_y = y;
				_width = width;
				_height = height;

				_timer = new Timer();
				_timer.Tick += tick;

				FillPoints(cellPoints);
				_currentBall = _nullBall;
			}

			private void FillPoints(CellPoint[,] cellPoints)
			{
				for (int i = 0, xx = (int)(_x - _width / 2); i < _width; i++, xx++)
				{
					for (int j = 0, yy = (int)(_y - _height / 2); j < _height; j++, yy++)
					{
						cellPoints[xx, yy] = _wallPoint;
					}
				}
			}

			private void ClearPoints(CellPoint[,] cellPoints)
			{
				for (int i = 0, xx = (int)(_x - _width / 2); i < _width; i++, xx++)
				{
					for (int j = 0, yy = (int)(_y - _height / 2); j < _height; j++, yy++)
					{
						cellPoints[xx, yy] = _voidPoint;
					}
				}
			}

			public void Draw(Graphics graphics)
			{
				graphics.FillRectangle(Brushes.White, _x - _width / 2, _y - _height / 2, _width, _height);
			}

			public void Move(CellPoint[,] cellPoints, float H)
			{
				ClearPoints(cellPoints);

				for (int i = 0; i < 10; i++)
				{
					if (_y > _height / 2 + 1 + 10 && _destination < _y || _y < H - _height / 2 - 2 - 10 && _destination > _y)
					{
						_y += Math.Sign(_destination - _y);
					}
				}

				_currentBall.Y = _y;

				FillPoints(cellPoints);
			}

			public void StartMove(float H)
			{
				_y = H / 2;
				_timer.Enabled = true;
				_timer.Interval = 1;
				_destination = _y;
				_currentBall = _nullBall;
			}

			public void StopMove()
			{
				_timer.Enabled = false;
			}

			public float X => _x;
			public float Y => _y;
			public float Width => _width;
			public float Height { get => _height; set { _height = value; } }
			public float Destination { get => _destination; set { _destination = value; } }
			public Ball CurrentBall { get => _currentBall; set { _currentBall = value; } }
		}

		private class Player
		{
			private int _score = 0;
			private int _id;
			private Platform _platform;

			public Player(Platform platform, int id)
			{
				_id = id;
				_platform = platform;
			}

			public void MovingPlatform(CellPoint[,] cellPoints, float height)
			{
				_platform.Move(cellPoints, height);
			}

			public void MovePlatform(float y)
			{
				_platform.Destination = y;
			}

			public void DrawPlatform(Graphics graphics)
			{
				_platform.Draw(graphics);
			}

			public void Start(float H)
			{
				_score = 0;
				_platform.StartMove(H);
			}

			public void Stop()
			{
				_platform.StopMove();
			}

			public void StartBall()
			{
				_platform.CurrentBall.Angle = _id * _pi + (_pi / 2 * _random.Next() - _pi / 4);
				_platform.CurrentBall.StartMove();
				_platform.CurrentBall = _nullBall;
			}

			public float Y => _platform.Y;
			public int ID => _id;
			public float Destination => _platform.Destination;
			public int Score { get => _score; set { _score = value; } }
			public Platform Platform => _platform;
		}

		public class Board
		{
			private int _width;
			private int _height;

			private Ball _ball;
			private PictureBox _picture;
			private Label _score;
			private TrackBar _trackVelocity;
			private TrackBar _trackPlatformSize;
			private TrackBar _trackBallSize;

			private CellPoint[,] _points;
			private Player[] _players = new Player[2];

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
						_points[x, y] = _wallPoint;

				for (int x = 10; x < width - 10; x++)
					for (int y = 10; y < height - 10; y++)
						_points[x, y] = _voidPoint;

				_ball = new RealBall(TickBall, trackBallSize.Value, trackVelocity.Value, width / 2, height / 2, 0);

				_players[0] = new Player(new Platform(_points, TickLeftPlatform, 15, trackPlatformSize.Value, 0.055F * width, height / 2), 0);
				_players[1] = new Player(new Platform(_points, TickRightPlatform, 15, trackPlatformSize.Value, 0.945F * width, height / 2), 1);

				_gate1 = new GatePoint(_players[0]);
				_gate2 = new GatePoint(_players[1]);

				for (int x = 0; x < 10; x++)
					for (int y = 10; y < height - 1; y++)
						_points[x, y] = _gate1;

				for (int x = width - 10; x < width; x++)
					for (int y = 10; y < height - 1; y++)
						_points[x, y] = _gate2;

				_picture.Paint += Paint;
				_picture.MouseMove += MouseMove;
				_picture.Click += Click;

				trackVelocity.Scroll += ScrollVelocity;
				trackPlatformSize.Scroll += ScrollPlaformSize;
				trackBallSize.Scroll += ScrollBallSize;
			}

			public void NewGame()
			{
				float alpha = _2pi * (float)_random.NextDouble();

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

			private void ScrollPlaformSize(object sender, EventArgs e)
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
			GameInfo gameInfo = new GameInfo();
			gameInfo.ShowDialog();
		}
	}
}
