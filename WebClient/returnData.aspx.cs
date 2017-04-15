using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class returnData : System.Web.UI.Page
    {
        public string data;
        public string guidkey;
        protected void Page_Load(object sender, EventArgs e)
        {
            data = "cI5dErmY1OiKPdmawO/BOnz2LPh0ruh8JJbO8KRB0BmzZwfWg5yVjsJZecPZcgQMw3vNNT77IWo3QiiTi2TbK4Y+ZxLdivIjBcnIpi2gbUmrL0ejUFwFya+LUUYgcyEHtWpuxkaetaejNIGYb8+IBOYegetgQ/HUtxQp+/RkFAyG5LnTW+v/t5dcQ7jpsAzq5qWLgZ21yDOcFQWeQcmJKtVosXyutlH3jvDuDiJWDMcOaLC3Tt3vWs4gSROrRQV80oyWYemacat/N+8abzIso0FX9FfRtiJhrAL75dj5Q8AyMsEiv5lsJphv3WBhcdNFA+Sj4pU4sKAmcp+NbQS0TO7G0bYze5Y9NSGk5Lg5jf6yqf6iMGT1SQHjKneVQpk6z/TAvAnU/h9nRotlw7ZuoO5vUrk6iWknqJ4EvNefcAJoDl+XTiF54A2K3eI7BPcROun8/iIjyU1RKwKypvbnYI9oY2zw7DK+liNbTgqKx5rhcZIpist1bFClMYs+mKni4Frt8KSHejjA1kPKDWRC/TdzHviOe8PFDAt4QzK6vfTuumdIVr0wgBQlacIPlMn2INto7ztaPynj5XPowkgoliZmQABzlO3p/lei2tOWi3OYXtKicYQ7JY1OF44oSe2tz5bhnj0Q3o3JZq1kcvyojtOcKR2wRosr1RwnHtXK5ENwHX7nyD+6FiD2VIGlWrGU9qyiR3NU+6jGY16WMuz0W3yDJN6GAIUbZGeznBldeijGGS5TbqQx1gl30OS9gjbuuiCVZnaYsZHthYeln8+4fJpjfaADq17j0zu5WLxq8aq7C2vBApB1DmkXR74u8zDRTFLLvnTmJWdrShJ+uQkXk1cNErkrl/ZSxiMO2TCyeDLRXK7tKAWz5P50tRWaNDyr6TaVwHXyz9FlBW88VjMG3kXCvntUCJakLmMtYtd2Zjb4xhMC2keplGP4tvBRd4t0x6OpHJ5wjdI4DDPTRDMTg/MoX8bguWd6JsIkFQMOLyBrjHGsWPxChlM3jFIpPahB0h9fOSAasktBryFAcU0EU8qJHrS8UArNWtksahQXjIsM1zLCikRiZ5SHlgbBIFRzy3nC8xnlMKXmDkatTtboxvqejJbqFsY//VfkYOZQV3YiYzoxd1mGYb+LslmO0YBrgh971PEziWeXKdYvDDX5hMNrw2mBNsttPaw60iz0k7mVZL7ThbY7zjTGEl7J2/b9KEEw6+a9E+y/9AiR27LLiOVdg27E+p71q/h5RxLgf4sjgQcn5y7ez1khuYV0z517HbjoplVcIdofTy4H/jKJ9ItSSZBAtugnQWjo1jA7qLNJz3LuN3679WmqdTsn1fbYxc8EnhuVWmtvolzdaGJA2oYn800ekOB0UiGWXO149WTjeSRi72W2viU8doX5lxpiPLkukDKAVetNvLSSlfy4KtRIxxnjZT+Nbd3/rsO1rZYyYiTeHEIX+kSi1vWcTaXu3P+WFVAgURY+fIB679RoAQdRKJud3j5VezAK4k+OEhI=";
            //data = Request["data"];
            //key = Request["key"];

            if (Request["action"] == "savedata")
            {
                string content = Request["content"];
                string guidkey = Request["guidkey"];
                string weekday = Request["weekday"];
                DateTime createDate = Convert.ToDateTime(Request["createDate"]);
                string weather = Request["weather"];
                diary ent = new diary();
                ent.Id = Guid.NewGuid().ToString();
                ent.key = guidkey;
                ent.content = content;
                ent.weekday = weekday;
                ent.createDate = createDate;
                ent.weather = weather;
                ent.CJTime = DateTime.Now;

                diaryEntities db = new diaryEntities();
                db.diary.Add(ent);
                db.SaveChanges();
            }
        }
    }
}