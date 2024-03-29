﻿using Library.Models;
using Library.Repository;
using System.Globalization;

namespace WF
{
    public partial class PlayerRankingControl : UserControl
    {
        public PlayerRankingControl player;
        private Player p = new Player();
        private static IRepository repo = RepositoryFactory.GiveThisManARepository();
        public PlayerRankingControl(Player player)
        {

            InitializeComponent();
            p = player;
        }

        private void PlayerRankingControl_Load(object sender, EventArgs e)
        {
            pbPlayer.Image = repo.GetImageForPlayer(p.Name);
            pbPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            lblName.Text = p.Name;
            lblGoalsNum.Text = p.GoalNumber.ToString();
            lblYCNumber.Text = p.YellowCardNumber.ToString();
        }
    }
}
