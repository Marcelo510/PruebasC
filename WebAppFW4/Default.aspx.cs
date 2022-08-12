using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFW4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void generar()
        {
            using(TransactionScope scope = new TransactionScope())
            {
                scope.Complete();
            }
        }


        TransactionScope transac = new TransactionScope();

        

    }
}