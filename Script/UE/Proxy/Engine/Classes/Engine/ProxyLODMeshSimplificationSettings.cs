using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ProxyLODMeshSimplificationSettings")]
	public partial class UProxyLODMeshSimplificationSettings : UDeveloperSettings, IStaticClass
	{
		public FName ProxyLODMeshReductionModuleName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProxyLODMeshReductionModuleName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProxyLODMeshReductionModuleName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ProxyLODMeshSimplificationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ProxyLODMeshReductionModuleName = 0;
	}
}