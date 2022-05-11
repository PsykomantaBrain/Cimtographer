using ICities;

namespace Mapper
{
	public class MapperMod : IUserMod
	{
		public string Name
		{
			get
			{
				return "Cimtographer - HRV edit";
			}
		}
		public string Description
		{
			get
			{
				return "Convert from and to OpenStreetMap format. - HRV version";
			}
		}
	}
}
