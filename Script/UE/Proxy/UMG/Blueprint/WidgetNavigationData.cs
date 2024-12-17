using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetNavigationData")]
	public partial class FWidgetNavigationData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.WidgetNavigationData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetNavigationData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWidgetNavigationData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWidgetNavigationData A, FWidgetNavigationData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetNavigationData A, FWidgetNavigationData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetNavigationData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EUINavigationRule Rule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rule, __ReturnBuffer);

					return *(EUINavigationRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rule, __InBuffer);
				}
			}
		}

		public FName WidgetToFocus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WidgetToFocus, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WidgetToFocus, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UWidget> Widget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Widget, __ReturnBuffer);

					return *(TWeakObjectPtr<UWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Widget, __InBuffer);
				}
			}
		}

		public FCustomWidgetNavigationDelegate CustomDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomDelegate, __ReturnBuffer);

					return *(FCustomWidgetNavigationDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomDelegate, __InBuffer);
				}
			}
		}

		private static uint __Rule = 0;

		private static uint __WidgetToFocus = 0;

		private static uint __Widget = 0;

		private static uint __CustomDelegate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}