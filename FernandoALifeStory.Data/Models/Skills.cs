using System.ComponentModel;

namespace FernandoALifeStory.Data.Models
{
    public enum Skills
    {
        UNDEFINED = 0,
        [Description("C#")]
        CSharp = 1,
        [Description(".NET")]
        dotNET = 2,
        [Description("ASP.NET")]
        ASPdotNET = 3,
        [Description("MVC")]
        MVC = 4,
        [Description("Microsoft Visual Studio")]
        VisualStudio = 5
    }
}
