using Script.CoreUObject;
using Script.Library;

namespace Script.UObjectPlugin
{
	[PathName("/Script/UObjectPlugin.MyPluginStruct")]
	public partial class FMyPluginStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UObjectPlugin.MyPluginStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMyPluginStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMyPluginStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMyPluginStruct A, FMyPluginStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMyPluginStruct A, FMyPluginStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMyPluginStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString TestString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TestString, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TestString, __InBuffer);
				}
			}
		}

		private static uint __TestString = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}