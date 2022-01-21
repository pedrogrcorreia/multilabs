using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultiLabs.Models;

namespace MultiLabs.Results {

    static public class ResultsUtils {
            private static List<Result> results = new List<Result>() {
            new Result { Id = 1, Name = "Negativo" },
            new Result { Id = 2, Name = "Positivo" },
            new Result { Id = 3, Name = "Inconclusivo" },
            new Result { Id = 4, Name = "Outro Valor" },
            new Result { Id = 5, Name = "Não realizado" },
        };

        static public List<Result> All {
            get {
                return results;
            }
        }

        static public IEnumerable<SelectListItem> ResultSelectList {
            get {
                return results.Select(r => new SelectListItem {
                    Text = r.Name,
                    Value = r.Id.ToString()
                });
            }
        }

    }


}
