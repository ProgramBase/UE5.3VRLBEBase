using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.PropertiesToRecordForClass")]
	public partial class FPropertiesToRecordForClass : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SequenceRecorder.PropertiesToRecordForClass");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertiesToRecordForClass() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertiesToRecordForClass() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertiesToRecordForClass A, FPropertiesToRecordForClass B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertiesToRecordForClass A, FPropertiesToRecordForClass B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertiesToRecordForClass;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UActorComponent> Class
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Class, __ReturnBuffer);

					return *(TSubclassOf<UActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Class, __InBuffer);
				}
			}
		}

		public TArray<FName> Properties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Properties, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Properties, __InBuffer);
				}
			}
		}

		private static uint __Class = 0;

		private static uint __Properties = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}