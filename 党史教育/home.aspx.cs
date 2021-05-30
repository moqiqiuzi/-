using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class home :DbPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Tools.BuildlinkList("zjyj", 4, 1, 1, zjyjLiteral1, Conn, false);
            Tools.BuildHomePhotoLink("zjyj", 4, 2, zjyjLiteral2, Conn, "img/jiaxingnanhu.jpg", 500, 300, false);
            Tools.BuildlinkList("zjyj", 4, 6, 8, zjyjLiteral3, Conn, false);
            Tools.BuildlinkList("jnhd", 3, 5, 5, jnhdLiteral, Conn, false);
            Tools.BuildlinkList("ywyl", 1, 5, 5, ywylLiteral, Conn, false);
            Tools.BuildHomePhotoLink("dsbn", 2, 1, dsbnLiteral1, Conn, "img/xiaoshuncun.jpg", 250, 150, true);
            Tools.BuildlinkList("dsbn", 2, 2, 3, dsbnLiteral2, Conn, false);
            Tools.BuildHomePhotoLink("dsbn", 2, 4, dsbnLiteral3, Conn, "img/jinianbei.jpg", 250, 150, true);
            Tools.BuildlinkList("dsbn", 2, 2, 6, dsbnLiteral4, Conn, false);
            Tools.BuildHomePhotoLink("djsc", 5, 1, djscLiteral1, Conn, "img/zhonggongyida.jpg", 250, 150, true);
            Tools.BuildlinkList("djsc", 5, 2, 3, djscLiteral2, Conn, false);
            Tools.BuildlinkList("djsc", 5, 7, 10, djscLiteral3, Conn, false);
        }
    }
}