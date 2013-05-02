using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asml_Level100Pikachus
{
    class FoeSD : SD
    {
        public int SearchandDestroy(bool reset)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.kachu);
            System.Media.SoundPlayer playerInf = new System.Media.SoundPlayer(Properties.Resources.pikapika);

            TargetManager tm = TargetManager.GetInstance();
            Controller controller = Controller.GetInstance();

            int i = 0;
            foreach (Target target in tm.TMTargets)
            {
                i++;
                if (target.friend == false)
                {
                    controller.MoveTo(target.x, target.y);

                    player.Play();
                    controller.Fire();
                    controller.SetNum(controller.GetNum() - 1);

                    playerInf.PlayLooping();

                    if (i != tm.TMTargets.Count)
                    {
                        if (reset == true)
                        {
                            controller.Launcher.Reset();
                        }
                    }
                }

                Thread.Sleep(250);
            }

            return i;
        }
    }
}
