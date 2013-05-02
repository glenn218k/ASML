using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asml_Level100Pikachus
{
    class SD : Asml
    {
        public void SearchandDestroy(bool reset, bool friend, bool foe, bool friendfoe, bool live)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.kachu);
            System.Media.SoundPlayer playerSound = new System.Media.SoundPlayer(Properties.Resources.pkmtheme);

            TargetManager tm = TargetManager.GetInstance();

            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            Controller cont = Controller.GetInstance();

            if(live == false)
                controller.Launcher.Reset();

            int i = 0;

            if (friend == true)
            {
                FriendSD friendClass = new FriendSD();

                i = friendClass.SearchandDestroy(reset);
            }
            else if (foe == true)
            {
                FoeSD foeClass = new FoeSD();

                i = foeClass.SearchandDestroy(reset);
            }
            else
            {
                FriendFoeSD friendFoeClass = new FriendFoeSD();

                i = friendFoeClass.SearchandDestroy(reset);
            }

            if (controller.GetNum() > 0)
            {
                playerSound.Play();
                controller.MoveBy(6000, 0);
                for (int j = 0; j < controller.GetNum();)
                {
                    controller.Fire();
                    controller.SetNum(controller.GetNum() - 1);
                }

                controller.SetNum(0);
                playerSound.Stop();
            }       
        }
    }
}
