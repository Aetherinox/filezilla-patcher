/*
    @app        : FileZilla Patcher
    @repo       : https://github.com/Aetherinox/filezilla-patcher
    @author     : Aetherinox
*/

#region "Using"

using System;
using System.Windows.Forms;

#endregion

/*

    Aetherx > Control > Button

    Button customization

*/

namespace FZillaPatcher
{

    public class AetherxButton : Button
    {

        /*
            Show keyboard cues no matter what.
            By default, user must press ALT to see them.
        */

        protected override bool ShowKeyboardCues
        {
            get
            {
                return true;
            }
        }
    }
}
