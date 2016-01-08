﻿using NestedWorld.Classes.ElementsGame.Areas;
using NestedWorld.Classes.ElementsGame.GameCore;
using NestedWorld.Classes.ElementsGame.Maps;
using NestedWorld.Classes.ElementsGame.Monsters;
using NestedWorld.Classes.ElementsGame.Users;
using NestedWorld.View.MonsterViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace NestedWorld.Classes
{
    public class Core
    {
        public MapCore mapCore { get; set; }
        public Garden.Garden garden { get; set; }
        public MonsterFullView mfv { get; set; }
        private UserMonster _monsterSelected;
        public UserMonster monsterSelected
        {
            get { return _monsterSelected; }
            set
            {
                _monsterSelected = value;
                mfv.monsterToDisplay = value;
            }
        }
        public MonsterList monsterList { get; set; }
        public MonsterList monsterUserList { get; set; }
        public UserList userList { get; set; }
        public AreaList areaList { get; set; }

        public UserInfo user { get; set; }

        public bool Offline { get; set; }
        public Core()
        {
            Offline = true;
            user = UserInfo.GetYou();
            userList = new UserList();

            monsterList = new MonsterList();
            monsterUserList = new MonsterList();
            userList = new UserList();
            areaList = new AreaList();
            garden = new Garden.Garden();
            mapCore = new MapCore(user);
           
        }

        public async void ShowError(string ErrorMessage)
        {
            var messageDialog = new MessageDialog(ErrorMessage);
            await messageDialog.ShowAsync();
        }

        public async Task Init()
        {

            userList.Init();
            if (Offline)
            {
                monsterList.init();
                monsterUserList.init();
              
            }
            else
            {
                string ret = await App.network.GetMonter(monsterList);
                ShowError(ret);
            }
        }

    }
}
