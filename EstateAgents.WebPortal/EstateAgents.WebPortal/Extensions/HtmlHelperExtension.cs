using EstateAgents.Library.Attributes;
using EstateAgents.Library.Extensions;
using System.Collections.Generic;
using System.Web.Helpers;
using System.Reflection;
using System.Web.Mvc;
using System.Linq;

namespace EstateAgents.WebPortal.Extensions
{
    public static class HtmlHelperExtension
    {
        public static int NgMaxLength(this HtmlHelper html, ViewDataDictionary viewData, int defaultValue = 50)
        {

            if (viewData["NgMaxLength"] != null)
                return (int)viewData["NgMaxLength"];

            PropertyInfo property = viewData.ModelMetadata.ContainerType.GetProperties().FirstOrDefault(i => i.Name == viewData.ModelMetadata.PropertyName);

            if (property != null && property.CheckIfMaxLengthAttributeExists())
                return property.MaxLengthAttribute().Length;

            return defaultValue;

        }

        public static string MutedText(this HtmlHelper html, ViewDataDictionary viewData)
        {

            if (viewData["MutedText"] != null)
                return viewData["MutedText"].ToString();

            PropertyInfo property = viewData.ModelMetadata.ContainerType.GetProperties().FirstOrDefault(i => i.Name == viewData.ModelMetadata.PropertyName);

            if (property != null && property.CheckIfMutedTextAttributeExists())
            {

                if (property.CheckIfMutedTextAttributeExists())
                    return property.MutedTextAttribute().Description;

            }

            return null;

        }

        public static string NgPattern(this HtmlHelper html, ViewDataDictionary viewData)
        {

            if (viewData["NgPattern"] != null)
                return viewData["NgPattern"].ToString();

            PropertyInfo property = viewData.ModelMetadata.ContainerType.GetProperties().FirstOrDefault(i => i.Name == viewData.ModelMetadata.PropertyName);

            if (property != null && property.CheckIfValidValueAttributeExists())
                return property.ValidValueAttribute().SetValue;

            return null;

        }

        public static string NgRequired(this HtmlHelper html, ViewDataDictionary viewData)
        {

            if (viewData.ModelMetadata.IsRequired)
                return "true";

            if (viewData["NgRequired"] != null)
                return viewData["NgRequired"].ToString();

            PropertyInfo property = viewData.ModelMetadata.ContainerType.GetProperties().FirstOrDefault(i => i.Name == viewData.ModelMetadata.PropertyName);

            if (property != null && property.CheckIfRequiredIfAttributeExists())
            {

                var props = property.GetCustomAttributes<RequiredIfAttribute>(true);
                var lst = new List<string>();

                foreach (RequiredIfAttribute att in props)
                {

                    PropertyInfo ciadp = viewData.ModelMetadata.ContainerType.GetProperty(att.Dependancy);

                    if (ciadp != null)
                        lst.Add(SetAngularArrayCheck(html, att.TargetValues, property, ciadp, true));

                }

                if (lst.Count > 0)
                {

                    if (lst.Count > 1)
                    {
                        lst = lst.Select(i => i.Insert(i.Count(), "&&")).ToList();
                        lst[lst.Count - 1] = lst.Last().Replace("&&", "");
                    }

                    return string.Join(string.Empty, lst.ToArray());

                }

            }

            return null;

        }

        /// <summary>
        /// Checks if the {RequiredIfAttribute} exists for the property
        /// </summary>
        private static string SetAngularArrayCheck(this HtmlHelper html, object[] array, PropertyInfo property, PropertyInfo dependancy, bool isRequired = false)
        {

            IEnumerable<object> lst = null;

            if (array.Count() == 0)
                return null;

            if (array.First().GetType().IsEnum)
                lst = array.Select(i => ((int)i).ToString());
            else if (array.First().GetType() == typeof(bool))

                if (dependancy.CheckIfUIHintAttributeExists() && dependancy.UIHintAttributeAttribute().UIHint == "DropDown")
                {
                    lst = array.Select(i => (i).ToString().ToLower());
                }
                else
                {
                    lst = array;
                }

            else
                lst = array.Select(i => (i).ToString());

            if (isRequired)
            {
                return string.Format("{0}.indexOf(Model.{1}){2}-1", html.Raw(Json.Encode(lst)), dependancy.Name, "!==", property.Name);
            }
            else
            {
                return string.Format("ShowHide({0}.indexOf(Model.{1}){2}-1,'{3}',{4})", html.Raw(Json.Encode(lst)), dependancy.Name, "!==", property.Name,
                                    property.CheckIfUIHintAttributeExists() && property.UIHintAttributeAttribute().UIHint == "CheckBox" ? "false" : "null");
            }

        }

    }
}