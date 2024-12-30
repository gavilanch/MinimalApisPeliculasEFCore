using Microsoft.IdentityModel.Tokens;

namespace MinimalAPIPeliculas.Utilidades
{
    public static class HttpContextExtensionsUtilidades
    {
        public static T ExtraerValorODefecto<T>(this HttpContext context, string nombreDelCampo, 
            T valorPorDefecto)
            where T : IParsable<T>
        {
            var valor = context.Request.Query[nombreDelCampo];

            if (!valor.Any())
            {
                return valorPorDefecto;
            }

            return T.Parse(valor!, null);
        }
    }
}
