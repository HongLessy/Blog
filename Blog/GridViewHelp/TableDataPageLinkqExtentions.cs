using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewHelp
{
    /// <summary>
    /// 拓展方法，目标位HtmlHelper对象添加表数据显示的方法
    /// </summary>
    public static class TableDataPageLinkqExtentions
    {
        public static TableDataPagedList<T> ToPagedList<T>(this IQueryable<T> allitems,int? pageIndex,int pageSize,string identityColumnName,string sortExpression)
        {
            var truePageIndex = pageIndex ?? 0;
            var itemIndex=truePageIndex*pageSize;
            var pageOfItems = allitems.Skip(itemIndex).Take(pageSize);

            return new TableDataPagedList<T>(pageOfItems,truePageIndex,pageSize,allitems.Count(),identityColumnName,sortExpression); 
        }
        public static TableDataPagedList<T> ToPagedList<T>(this IQueryable<T> allitems, int? pageIndex, int pageSize,string identityColumnName)
        {           
            return ToPagedList(allitems, pageIndex, pageSize,identityColumnName, null);
        }
        public static TableDataPagedList<T> ToPagedList<T>(this IQueryable<T> allitems, int? pageIndex, int pageSize)
        {
            return ToPagedList(allitems, pageIndex, pageSize, null,string.Empty);
        }
    }
}
