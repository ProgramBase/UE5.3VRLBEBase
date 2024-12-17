using Script.CoreUObject;
using Script.Library;

namespace Script.JsonUtilities
{
	[PathName("/Script/JsonUtilities.JsonObjectWrapper")]
	public partial class FJsonObjectWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/JsonUtilities.JsonObjectWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FJsonObjectWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FJsonObjectWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FJsonObjectWrapper A, FJsonObjectWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FJsonObjectWrapper A, FJsonObjectWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FJsonObjectWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString JsonString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __JsonString, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __JsonString, __InBuffer);
				}
			}
		}

		private static uint __JsonString = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}