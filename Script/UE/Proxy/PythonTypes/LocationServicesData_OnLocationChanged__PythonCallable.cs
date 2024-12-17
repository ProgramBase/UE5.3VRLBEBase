using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/LocationServicesData_OnLocationChanged__PythonCallable.LocationServicesData_OnLocationChanged__PythonCallable")]
	public partial class LocationServicesData_OnLocationChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/LocationServicesData_OnLocationChanged__PythonCallable.LocationServicesData_OnLocationChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}