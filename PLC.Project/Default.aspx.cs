using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;

namespace PLC.Project
{
    public partial class _Default : Page



    {


        protected void Page_Load(object sender, EventArgs e)
        {
            String name1 = "1";
            String name2 = "2";
            String name3 = "3";
            String name4 = "4";
            String name5 = "5";
            String name6 = "6";
            String name7 = "7";
            String name8 = "8";
            String name9 = "9";
            String name10 = "10";
            String name11 = "11";
            String name12 = "12";
            String name13 = "13";
            String name14 = "14";
            String name15 = "15";
            String name16 = "16";
            String name17 = "17";








            if (!Page.IsPostBack)
            {

                Session[name1] = 0;
                Session[name2] = 0;
                Session[name3] = 0;
                Session[name4] = 0;
                Session[name5] = 0;
                Session[name6] = 0;
                Session[name7] = 0;
                Session[name8] = 0;
                Session[name9] = 0;
                Session[name10] = 0;
                Session[name11] = 0;
                Session[name12] = 0;
                Session[name13] = 0;
                Session[name14] = 0;
                Session[name15] = 0;
                Session[name16] = 0;
                Session[name17] = 0;


            }
            else
            {


            }
        }



        private void count (MODEL.Data model)
            {

            HtmlButton button = new HtmlButton();
            HtmlButton button_stop = new HtmlButton();
            string tmp = "0";
            tmp = Session[model.Line_Name].ToString();
            switch (model.Line_Name)
            {
                case "1":
                    button = L1;
                    button_stop = S1;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span1.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "2":
                    button = L2;
                    button_stop = S2;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span2.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "3":
                    button = L3;
                    button_stop = S3;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span3.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "4":
                    button = L4;
                    button_stop = S4;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span4.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "5":
                    button = L5;
                    button_stop = S5;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span5.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "6":
                    button = L6;
                    button_stop = S6;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span6.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "7":
                    button = L7;
                    button_stop = S7;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span7.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "8":
                    button = L8;
                    button_stop = S8;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span8.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "9":
                    button = L9;
                    button_stop = S9;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span9.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "10":
                    button = L10;
                    button_stop = S10;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span10.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "11":
                    button = L11;
                    button_stop = S11;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span11.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "12":
                    button = L12;
                    button_stop = S12;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span12.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "13":
                    button = L13;
                    button_stop = S13;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span13.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "14":
                    button = L14;
                    button_stop = S14;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span14.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "15":
                    button = L15;
                    button_stop = S15;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span15.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "16":
                    button = L16;
                    button_stop = S16;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span16.InnerHtml = Session[model.Line_Name].ToString();
                    break;
                case "17":
                    button = L17;
                    button_stop = S17;
                    Session[model.Line_Name] = Convert.ToInt32(tmp) + 1;
                    Span17.InnerHtml = Session[model.Line_Name].ToString();
                    break;
            }


            button.Attributes["class"] = "btn btn-success center-block";

        
            if (tmp == "31")
            {
                BLL.Data bLL = new BLL.Data();
                bLL.NoActive(model);
                button.Attributes["class"] = "btn btn-danger center-block";
                return;
            }


            Int32 tmpCountBack;
           tmpCountBack= 30 - Convert.ToInt32(tmp);
            SHOWCOUNT.InnerHtml = tmpCountBack.ToString() + "/30";


       
        }


        protected void Timer1_Tick(object sender, EventArgs e)
        {

            MODEL.Production mod = new MODEL.Production();
            BLL.Data _BLL = new BLL.Data();

            mod = _BLL.getStatus();

            ArrayList arrL = new ArrayList();
            arrL = mod.line;
            MODEL.Data mod_data = new MODEL.Data();
            if (arrL.Count > 0 )
            {
                for (int i = 0; i < arrL.Count; i++)
                {
                  
                    mod_data = (MODEL.Data)arrL[i];
                  
                    if(mod_data.Production_active == "1")
                    {
                     
                        count(mod_data);    
                    }
                    else
                    {
                      //  L1.Attributes["class"] = "btn btn-danger center-block";

                    
                    }
                }



            }



            //L1.Attributes["class"] = "btn btn-success center-block";

            //Span1.InnerHtml = "1";

        }
    }
}