using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MultiLabs.Roles {
    static public class RolesUtils {
        private static List<IdentityRole<int>> roles = new List<IdentityRole<int>> {
            new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "1"},
            new IdentityRole<int> { Id = 2, Name = "LabManager", NormalizedName = "LABMANAGER", ConcurrencyStamp = "2"},
            new IdentityRole<int> { Id = 3, Name = "LabTester", NormalizedName = "LABTESTER", ConcurrencyStamp = "3"},
            new IdentityRole<int> { Id = 4, Name = "Client", NormalizedName = "CLIENT", ConcurrencyStamp = "4"},
        };

        static public List<IdentityRole<int>> All {
            get {
                return roles;
            }
        }

        static public IEnumerable<SelectListItem> RegistSelectList {
            get {
                return roles.Where(r => r.Id == 2 || r.Id == 4).Select(r => new SelectListItem {
                    Text = r.Name,
                    Value = r.Id.ToString()
                });
            }
        }

    }
}
