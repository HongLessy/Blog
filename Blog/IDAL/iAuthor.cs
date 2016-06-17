
///
//创建项目 
//创建人：HonLessy
//创建时间2016年6月17日
///

using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

using Blog.Model;

namespace Blog.IDAL
{
    
    ///
    //Author的描述
    ///
    public interface IAuthor
    {
          AuthorEntity SelectAuthorByID(int t_author_id);       
        //根据主键查询整个表
          IList<AuthorEntity> GetAllAuthor();      
        //根据外键进行查询
          IList<AuthorEntity> GetAllAuthorByrole_id(int t_role_id);
        //插入操作
          int InsertAuthor(AuthorEntity t_Author);       
        //修改操作
          int UpdateAuthor(AuthorEntity t_Author);
        //删除操作
          int DeleteAuthor(int t_author_id);
       
    }
}