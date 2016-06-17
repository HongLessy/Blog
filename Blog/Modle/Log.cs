///
//创建项目
//创建人：HonLessy
//创建时间2016年6月17日
///

using System;

namespace Blog.Model
{
	public class LogEntity
	{
		protected int _id;
		protected int _author_id;
		protected DateTime _date;
		protected string _operatevent = String.Empty;
	
		public LogEntity()
		{
			
		}
		
		public LogEntity(int id,int author_id,DateTime date,string operatevent)
		{
			_id = id ;	
			_author_id = author_id ;	
			_date = date ;	
			_operatevent = operatevent ;	
		}
		
		public int  Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id=value;
			}				
		}
			
		public int  Author_id
		{
			get
			{
				return _author_id;
			}
			set
			{
				_author_id=value;
			}				
		}
			
		public DateTime  Date
		{
			get
			{
				return _date;
			}
			set
			{
				_date=value;
			}				
		}
			
		public string  Operatevent
		{
			get
			{
				return _operatevent;
			}
			set
			{
				_operatevent=value;
			}				
		}
			
	}
}


