using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.DefaultContextSetting")]
	public partial class FDefaultContextSetting : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.DefaultContextSetting");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDefaultContextSetting() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDefaultContextSetting() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDefaultContextSetting A, FDefaultContextSetting B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDefaultContextSetting A, FDefaultContextSetting B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDefaultContextSetting;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<UInputMappingContext> InputMappingContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputMappingContext, __ReturnBuffer);

					return *(TSoftObjectPtr<UInputMappingContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputMappingContext, __InBuffer);
				}
			}
		}

		public int Priority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Priority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Priority, __InBuffer);
				}
			}
		}

		private static uint __InputMappingContext = 0;

		private static uint __Priority = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}