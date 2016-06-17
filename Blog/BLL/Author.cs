
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
using Blog.DBUtility;
using Blog.IDAL;
using Blog.SqlServerDAL;
using Blog.AccessDAL;
using Blog.DALFactory;


namespace Blog.BLL
{
    
    ///
    //Author的描述
    ///
    public static class AuthorManager
    {
        private static Blog.IDAL.IAuthor dal=Blog.DALFactory.DataAccess.CreateAuthor();
        
        public static AuthorEntity SelectAuthorByID(int t_author_id)
        {
            AuthorEntity temp=null;
            try
            {
                temp=dal.SelectAuthorByID(t_author_id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return temp;
        }
        
        //根据主键查询整个表
        public static IList<AuthorEntity> GetAllAuthor()
        {
            IList<AuthorEntity> temp=null;
            try
            {
                temp=GetAllAuthor();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return temp;
        }
        
        
        //根据外键进行查询
        public static IList<AuthorEntity> GetAllAuthorByrole_id(int t_role_id)
        {
           IList<AuthorEntity> temp=null;
           try
            {
                temp=GetAllAuthorByrole_id(t_role_id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return temp;
        }
        

        
        //插入操作
        public static int InsertAuthor(AuthorEntity t_Author)
        {
            int i=-1;
            //定义插入数据的参数数组
            try
            {
                i=InsertAuthor(t_Author);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           return i;
        }
        
        public static int UpdateAuthor(AuthorEntity t_Author)
        {
            int i=-1;
            //定义插入数据的参数数组
            try
            {
                i=UpdateAuthor(t_Author);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return i;
        }
        
        public static int DeleteAuthor(int t_author_id)
        {
            int i=-1;
            //定义插入数据的参数数组
            try
            {
                i=DeleteAuthor(t_author_id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return i;
        }
    }
}