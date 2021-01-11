using Project.BLL.DesignPatterns.RepositoryPattern.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.RepositoryPattern.ConcRep
{
    public class ArticleRepository:BaseRepository<Article>
    {

        public override List<Article> GetAll()
        {
           return _db.Articles.Where(x => x.Category.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();
        }
    }
}
