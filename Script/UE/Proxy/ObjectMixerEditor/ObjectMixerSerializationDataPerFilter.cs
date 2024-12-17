using Script.CoreUObject;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerSerializationDataPerFilter")]
	public partial class FObjectMixerSerializationDataPerFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ObjectMixerEditor.ObjectMixerSerializationDataPerFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectMixerSerializationDataPerFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FObjectMixerSerializationDataPerFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FObjectMixerSerializationDataPerFilter A, FObjectMixerSerializationDataPerFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectMixerSerializationDataPerFilter A, FObjectMixerSerializationDataPerFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectMixerSerializationDataPerFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName FilterClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterClassName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterClassName, __InBuffer);
				}
			}
		}

		public TArray<FObjectMixerCollectionObjectSet> SerializedCollections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SerializedCollections, __ReturnBuffer);

					return *(TArray<FObjectMixerCollectionObjectSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SerializedCollections, __InBuffer);
				}
			}
		}

		public TSet<FObjectMixerColumnData> SerializedColumnData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SerializedColumnData, __ReturnBuffer);

					return *(TSet<FObjectMixerColumnData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SerializedColumnData, __InBuffer);
				}
			}
		}

		private static uint __FilterClassName = 0;

		private static uint __SerializedCollections = 0;

		private static uint __SerializedColumnData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}