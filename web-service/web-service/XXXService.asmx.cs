using System.Web.Services;

namespace web_service
{
    /// <summary>
    /// Сводное описание для XXXService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]        // пространство имен, http://tempuri.org/ - отладочное пространство имен для службы
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]       //устанавливает профиль совместимости 
    [System.ComponentModel.ToolboxItem(false)]      //управление панелью элементов VS Toolbox
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class XXXService : System.Web.Services.WebService
    {

        [WebMethod (Description ="Sum", EnableSession =true)]       //EnableSession указывает включено ли состояние сессии для WebMethod
        public int Sum(int x,int y)
        {
            return x+y;
        }

        [WebMethod(Description = "Sub", EnableSession = true)]       //EnableSession указывает включено ли состояние сессии для WebMethod
        public int Sub(int x, int y)
        {
            return x - y;
        }

        [WebMethod(Description = "Mul", EnableSession = true)]       //EnableSession указывает включено ли состояние сессии для WebMethod
        public int Mul(int x, int y)
        {
            return x * y;
        }

        private int i = 0;

        [WebMethod(Description = "Set i", EnableSession = true)]       //EnableSession указывает включено ли состояние сессии для WebMethod
        public void SetI(int i)
        {
            //Session["i"] = i;
            Application.Remove("i");
            Application.Add("i", i);
        }

        [WebMethod(Description = "Get i", EnableSession = true)]       //EnableSession указывает включено ли состояние сессии для WebMethod
        public int GetI()
        {
            int rc = 0;
            //if (Session["i"] != null)
            //{
            //    rc = (int)Session["i"];
            //}
            if (Application.Get("i") != null)
            {
                rc = (int)Application.Get("i");
            }

            return rc;           
        }

        [WebMethod(Description = "Add i and return", EnableSession = true)]       //EnableSession указывает включено ли состояние сессии для WebMethod
        public int AddI(int i)
        {
            int rc = 0;
            //if (Session["i"] != null)
            //{
            //    rc = (int)Session["i"]+i;
            //}

            if (Application.Get("i") != null)
            {
                rc = (int)Application.Get("i") + i;
            }
            return rc;
        }


    }
}
