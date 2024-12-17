using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.FieldPathNetSerializerSerializationHelper")]
	public partial class FFieldPathNetSerializerSerializationHelper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.FieldPathNetSerializerSerializationHelper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFieldPathNetSerializerSerializationHelper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFieldPathNetSerializerSerializationHelper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFieldPathNetSerializerSerializationHelper A, FFieldPathNetSerializerSerializationHelper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFieldPathNetSerializerSerializationHelper A, FFieldPathNetSerializerSerializationHelper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFieldPathNetSerializerSerializationHelper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UStruct> Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(TWeakObjectPtr<UStruct>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public TArray<FName> PropertyPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyPath, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyPath, __InBuffer);
				}
			}
		}

		private static uint __Owner = 0;

		private static uint __PropertyPath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}