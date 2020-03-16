using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFDemo.Entry
{
	public class Mef
	{
		//根据导出名称导入
		[Import("Cat")]
		public IAnimal Cat;
		//根据到处类型导入多个
		[ImportMany(typeof(IAnimal))]
		public IEnumerable<IAnimal> Animals;
		[Import("Cat")]
		public Lazy<IAnimal> Kitty;
		//根据导出名称导入字段
		[Import("Age")]
		public int Age;
		//根据导出名称导入属性
		[Import("Owner")]
		public string Owner { get; set; }
		//根据导出名称导入无参方法
		[Import("Run")]
		public Action Run;
		//根据导出名称导入入参为string返回值为string的方法
		[Import("GetInfo")]
		public Func<string, string> GetInfo;
		//TODO:ImportingConstructor
		//配置容器
		public void Config()
		{
			DirectoryCatalog catalog = new DirectoryCatalog(Environment.CurrentDirectory);
			CompositionContainer container = new CompositionContainer(catalog);
			container.ComposeParts(this);
		}
	}
}
