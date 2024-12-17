using Script.CoreUObject;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.VersionInfoHandler")]
	public partial class UVersionInfoHandler : UObject, IStaticClass
	{
		public FVersionData CommonVersionData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CommonVersionData, __ReturnBuffer);

					return *(FVersionData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CommonVersionData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MegascansPlugin.VersionInfoHandler");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UVersionInfoHandler Get()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __Get, __ReturnBuffer);

				return *(UVersionInfoHandler*)__ReturnBuffer;
			}
		}

		private static uint __CommonVersionData = 0;

		private static uint __Get = 0;
	}
}