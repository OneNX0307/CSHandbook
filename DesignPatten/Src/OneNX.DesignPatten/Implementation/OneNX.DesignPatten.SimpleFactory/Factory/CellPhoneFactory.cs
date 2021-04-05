using OneNX.DesignPatten.SimpleFactory.Enum;
using OneNX.DesignPatten.SimpleFactory.Interface;
using OneNX.DesignPatten.SimpleFactory.Model.Cellphone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.SimpleFactory.Factory
{
	public class CellphoneFactory
	{
		public ICellphone GetCellPhone(CellphoneBrandEnum cellPhoneBrandEnum)
		{
			switch (cellPhoneBrandEnum)
			{
				case CellphoneBrandEnum.Xiaomi:
					return new Xiaomi();
				case CellphoneBrandEnum.Meizu:
					return new Meizu();
				case CellphoneBrandEnum.Huawei:
					return new Huawei();
				default:
					throw new ArgumentException($"Can't create cellphone with type {cellPhoneBrandEnum}.");
			}
		}
	}
}
