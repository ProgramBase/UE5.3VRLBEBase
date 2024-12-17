using Script.CoreUObject;
using Script.Library;

namespace Script.VariantManager
{
	[PathName("/Script/VariantManager.CapturableProperty")]
	public partial class FCapturableProperty : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/VariantManager.CapturableProperty");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCapturableProperty() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCapturableProperty() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCapturableProperty A, FCapturableProperty B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCapturableProperty A, FCapturableProperty B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCapturableProperty;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DisplayName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DisplayName, __InBuffer);
				}
			}
		}

		private static uint __DisplayName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}