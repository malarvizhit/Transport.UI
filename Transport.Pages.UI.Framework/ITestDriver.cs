using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Pages.UI.Framework
{
    public interface ITestDriver
    {
        bool IsVisibleByCss(string cssSelector);
        void ClickByCss(string cssSelector);
        void EnterTextByCss(string cssSelector, string text);
        string GetTextByCss(string cssSelector);
        void NavigateTo(string url);
        void SelectValueFromDropdownbyIndex(string cssSelector, string value);
        void Tab();
    }
}
