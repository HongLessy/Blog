
///
//创建项目
//创建人：HonLessy
//创建时间2016年6月17日
///

using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System;

using Blog.Model;
using Blog.DBUtility;
using Blog.IDAL;

namespace Blog.AccessDAL
{
    
    ///
    //Author的描述
    ///
    public class Author:IAuthor
    {
    
        public AuthorEntity SelectAuthorByID(int t_author_id)
        {
            AuthorEntity t_Author= new AuthorEntity();
            OleDbDataReader sdr=null;
            using(sdr=OLEDBHelp.GetReader("select * from Author where author_id="+t_author_id))
            {
                if(sdr.Read())
                {
                    t_Author.Author_id=(int)sdr.GetValue(0);
                    t_Author.Username=(string)sdr.GetValue(1);
                    t_Author.Password=(string)sdr.GetValue(2);
                    t_Author.Role_id=(int)sdr.GetValue(3);
                    t_Author.Islock=(string)sdr.GetValue(4);
                }
            }
            sdr.Close(); 
            return t_Author;
        }
        
        //根据主键查询整个表
        public IList<AuthorEntity> GetAllAuthor()
        {
            IList<AuthorEntity> t_Authors = new List<AuthorEntity>();
            OleDbDataReader sdr = null;
            using(sdr=OLEDBHelp.GetReader("select * from Author"))
            {
                while(sdr.Read())
                {
                    AuthorEntity t_Author= new AuthorEntity();
                    t_Author.Author_id=(int)sdr.GetValue(0);                  
                    t_Author.Username=(string)sdr.GetValue(1);                  
                    t_Author.Password=(string)sdr.GetValue(2);                  
                    t_Author.Role_id=(int)sdr.GetValue(3);                  
                    t_Author.Islock=(string)sdr.GetValue(4);                  
                    t_Authors.Add(t_Author);
                }
                sdr.Close();
            }
            return t_Authors;
        }
        
        
        //根据外键进行查询
        public IList<AuthorEntity> GetAllAuthorByrole_id(int t_role_id)
        {
           IList<AuthorEntity> t_Authors = new List<AuthorEntity>();
           OleDbDataReader sdr = null;
           using(sdr=OLEDBHelp.GetReader("select * from Author where role_id="+t_role_id))
           {
              while(sdr.Read())
                {
                    AuthorEntity t_Author= new AuthorEntity();
                    t_Author.Author_id=(int)sdr.GetValue(0);                    
                    t_Author.Username=(string)sdr.GetValue(1);                    
                    t_Author.Password=(string)sdr.GetValue(2);                    
                    t_Author.Role_id=(int)sdr.GetValue(3);                    
                    t_Author.Islock=(string)sdr.GetValue(4);                    
                    t_Authors.Add(t_Author);
                }
                sdr.Close();
            }
            return t_Authors;
        }
        

        
        //插入操作
        public int InsertAuthor(AuthorEntity t_Author)
        {
          //定义插入数据的参数数组
              OleDbParameter[] p=new OleDbParameter[]{
              new OleDbParameter("@Author_id",t_Author.Author_id),
              new OleDbParameter("@Username",t_Author.Username),
              new OleDbParameter("@Password",t_Author.Password),
              new OleDbParameter("@Role_id",t_Author.Role_id),
              new OleDbParameter("@Islock",t_Author.Islock)
           };
           int i=OLEDBHelp.GetExecute("insert into Author values (@Author_id,@Username,@Password,@Role_id,@Islock)", p) ;
           return i;
        }
        
        public int UpdateAuthor(AuthorEntity t_Author)
        {
            OleDbParameter[] p=new OleDbParameter[]{
            new OleDbParameter("@Author_id",t_Author.Author_id),
            new OleDbParameter("@Username",t_Author.Username),
            new OleDbParameter("@Password",t_Author.Password),
            new OleDbParameter("@Role_id",t_Author.Role_id),
            new OleDbParameter("@Islock",t_Author.Islock)
            };
            int i=OLEDBHelp.GetExecute("update Author set author_id=@Author_id,username=@Username,password=@Password,islock=@Islock where author_id=@Author_id", p) ;
            return i;
        }
        
        public int DeleteAuthor(int t_author_id)
        {
            int i=OLEDBHelp.GetExecute("delete from Author where author_id="+t_author_id);
			return i;
        }
    }
}