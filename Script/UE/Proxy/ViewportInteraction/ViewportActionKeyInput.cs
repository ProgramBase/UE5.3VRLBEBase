using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ViewportActionKeyInput")]
	public partial class FViewportActionKeyInput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ViewportInteraction.ViewportActionKeyInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FViewportActionKeyInput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FViewportActionKeyInput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FViewportActionKeyInput A, FViewportActionKeyInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FViewportActionKeyInput A, FViewportActionKeyInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FViewportActionKeyInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ActionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActionType, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActionType, __InBuffer);
				}
			}
		}

		public EInputEvent Event
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Event, __ReturnBuffer);

					return *(EInputEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Event, __InBuffer);
				}
			}
		}

		public bool bIsInputCaptured
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsInputCaptured, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsInputCaptured, __InBuffer);
				}
			}
		}

		public bool bIsAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsAxis, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsAxis, __InBuffer);
				}
			}
		}

		private static uint __ActionType = 0;

		private static uint __Event = 0;

		private static uint __bIsInputCaptured = 0;

		private static uint __bIsAxis = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}