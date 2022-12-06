using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruccionDeConsulta
{
    internal class Query : sqlBaseVisitor<string>
    {
        public override string VisitCampo(sqlParser.CampoContext context)
        {
            return base.VisitCampo(context);
        }

        public override string VisitColumna(sqlParser.ColumnaContext context)
        {
            return base.VisitColumna(context);
        }

        public override string VisitColumna_p(sqlParser.Columna_pContext context)
        {
            return base.VisitColumna_p(context);
        }

        public override string VisitTabla(sqlParser.TablaContext context)
        {
               
            return base.VisitTabla(context);
        }

        public override string VisitSql(sqlParser.SqlContext context)
        {
            return base.VisitSql(context);
        }
    }
}
