using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.ComponentModel;
using System.Resources;
using System.Reflection;
using System.Web;
using Models.App_GlobalResources;
using PacienteVirtual.Models;

namespace Model.Helpers
{
    public static class Extension
    {
        public static MvcHtmlString EnumDropDownListFor<TModel, TProperty, TEnum>(
                    this HtmlHelper<TModel> htmlHelper,
                    Expression<Func<TModel, TProperty>> expression,
                    TEnum selectedValue)
        {


            IEnumerable<TEnum> values = Enum.GetValues(typeof(TEnum))
                                        .Cast<TEnum>();

            IEnumerable<SelectListItem> items = from value in values
                                                select new SelectListItem()
                                                {
                                                    Text = value.ToString(),
                                                    Value = value.ToString(),
                                                    Selected = (value.Equals(selectedValue))
                                                };

            LocalizarDisplayNomeAtributo[] listaItens = new LocalizarDisplayNomeAtributo[values.Count()];
            LocalizarDisplayNomeAtributo na;
            int i = 0;
            foreach (var item in items)
            {
                na = new LocalizarDisplayNomeAtributo(item.Text);
                na.NameResourceType = typeof(Mensagem);
                listaItens[i] = na;
                i++;
            }

            i = 0;
            IEnumerable<SelectListItem> valores = from value in values
                                                  select new SelectListItem()
                                                  {
                                                      Text = listaItens[i++].DisplayName,
                                                      Value = value.ToString(),
                                                      Selected = (value.Equals(selectedValue))
                                                  };

            return SelectExtensions.DropDownListFor(htmlHelper, expression, valores);
        }
    }
}