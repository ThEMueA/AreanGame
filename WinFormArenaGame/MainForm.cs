using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using System.Reflection.Metadata;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            tbAttacker = tbKnight;
            if (args.Attacker is Knight)
                tbAttacker = tbKnight;

            if (args.Attacker is Dio)
                tbAttacker = TbDio;

            if (args.Attacker is Driver)
                tbAttacker = TBDriver;

            if (args.Attacker is Assassin)
                tbAttacker = tbAssassin;



            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbAssassin.Text = "";
            TBDriver.Text = "";
            TbDio.Text = "";
            tbKnight.Text = "";
            lbWinner.Visible = false;
            GameEngine gameEngine;


            //тези 1000 реда код са за избиране на герой, работят добре не ги глеайте
            if (checkBox1.Checked && checkBox2.Checked)
            {

                if (KA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("KnightA", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Knight("KnightB", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;




                }
                if (KA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }

                ///aaaaaaaaaaaaaaaaaaaaaaaaaaa
                if (AA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("AssassinA", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Assassin("AssassinB", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                //aaaaaaaaaaa

                if (DA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrandoA", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Dio("DioBrandoB", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                ////////////////

                if (DRA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("MazepinA", 10, 20, new Car("Opel Astra")),
                        HeroB = new Driver("MazepinB", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }

            }
            else if (checkBox1.Checked)
            {
                if (KA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("KnightA", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Knight("KnightB", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;




                }
                if (KA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }

                ///aaaaaaaaaaaaaaaaaaaaaaaaaaa
                if (AA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Knight("Knight", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("AssassinA", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Assassin("AssassinB", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                //aaaaaaaaaaa

                if (DA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Knight("Knight", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrandoA", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Dio("DioBrandoB", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                ////////////////

                if (DRA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Knight("Knight", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("MazepinA", 10, 20, new Car("Opel Astra")),
                        HeroB = new Driver("MazepinB", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }




            }
            else if (checkBox2.Checked)
            {
                if (KA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("KnightA", 10, 20, new Sword("Sword")),
                        HeroB = new Knight("KnightB", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;




                }
                if (KA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                        HeroB = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }

                ///aaaaaaaaaaaaaaaaaaaaaaaaaaa
                if (AA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        HeroB = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("AssassinA", 10, 5, new Dagger("Dagger")),
                        HeroB = new Assassin("AssassinB", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                //aaaaaaaaaaa

                if (DA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrandoA", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Dio("DioBrandoB", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                ////////////////

                if (DRA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Knight("Knight", 10, 20, new Revolver("Smith & Wesson Bodyguard Model 638 ")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Assassin("Assassin", 10, 5, new Revolver("Smith & Wesson Bodyguard Model 638")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("MazepinA", 10, 20, new Car("Opel Astra")),
                        HeroB = new Driver("MazepinB", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }




            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                if (KA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("KnightA", 10, 20, new Sword("Sword")),
                        HeroB = new Knight("KnightB", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;




                }
                if (KA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                        HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (KA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }

                ///aaaaaaaaaaaaaaaaaaaaaaaaaaa
                if (AA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        HeroB = new Knight("Knight", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("AssassinA", 10, 5, new Dagger("Dagger")),
                        HeroB = new Assassin("AssassinB", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (AA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                //aaaaaaaaaaa

                if (DA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Knight("Knight", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrandoA", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Dio("DioBrandoB", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        HeroB = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                ////////////////

                if (DRA.Checked && KB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Knight("Knight", 10, 20, new Sword("Sword")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && AB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("Mazepin", 10, 20, new Car("Opel Astra")),
                        HeroB = new Dio("DioBrando", 11, 11, new Stand("ZaWardo")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }
                if (DRA.Checked && DRB.Checked)
                {
                    gameEngine = new GameEngine()
                    {
                        HeroA = new Driver("MazepinA", 10, 20, new Car("Opel Astra")),
                        HeroB = new Driver("MazepinB", 10, 20, new Car("Opel Astra")),
                        NotificationsCallBack = gameNotification
                    };

                    imgFight.Enabled = true;
                    gameEngine.Fight();
                    imgFight.Enabled = false;

                    lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                    lbWinner.Visible = true;
                }




            }
            /*//Сетих се ,че може да не пиша 800 реда код, но малко късно.
             * Нищо поне ще видите че не съм преписал от никого :)*/
        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void tbAssassin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TbDio_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}