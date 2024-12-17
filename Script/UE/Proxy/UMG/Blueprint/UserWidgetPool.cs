using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserWidgetPool")]
	public partial class FUserWidgetPool : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.UserWidgetPool");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUserWidgetPool() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FUserWidgetPool() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FUserWidgetPool A, FUserWidgetPool B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUserWidgetPool A, FUserWidgetPool B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUserWidgetPool;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UUserWidget> ActiveWidgets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveWidgets, __ReturnBuffer);

					return *(TArray<UUserWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveWidgets, __InBuffer);
				}
			}
		}

		public TArray<UUserWidget> InactiveWidgets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InactiveWidgets, __ReturnBuffer);

					return *(TArray<UUserWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InactiveWidgets, __InBuffer);
				}
			}
		}

		private static uint __ActiveWidgets = 0;

		private static uint __InactiveWidgets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}