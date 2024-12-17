using Script.CoreUObject;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerCollectionObjectSet")]
	public partial class FObjectMixerCollectionObjectSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ObjectMixerEditor.ObjectMixerCollectionObjectSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectMixerCollectionObjectSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FObjectMixerCollectionObjectSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FObjectMixerCollectionObjectSet A, FObjectMixerCollectionObjectSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectMixerCollectionObjectSet A, FObjectMixerCollectionObjectSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectMixerCollectionObjectSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CollectionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollectionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollectionName, __InBuffer);
				}
			}
		}

		public TArray<FObjectMixerCollectionObjectData> CollectionObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollectionObjects, __ReturnBuffer);

					return *(TArray<FObjectMixerCollectionObjectData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollectionObjects, __InBuffer);
				}
			}
		}

		private static uint __CollectionName = 0;

		private static uint __CollectionObjects = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}