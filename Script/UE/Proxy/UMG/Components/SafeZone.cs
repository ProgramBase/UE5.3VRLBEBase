using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.SafeZone")]
	public partial class USafeZone : UContentWidget, IStaticClass
	{
		public bool PadLeft
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PadLeft, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PadLeft, __InBuffer);
				}
			}
		}

		public bool PadRight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PadRight, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PadRight, __InBuffer);
				}
			}
		}

		public bool PadTop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PadTop, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PadTop, __InBuffer);
				}
			}
		}

		public bool PadBottom
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PadBottom, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PadBottom, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.SafeZone");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSidesToPad(bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(bool*)(__InBuffer) = InPadLeft;

				*(bool*)(__InBuffer + 1) = InPadRight;

				*(bool*)(__InBuffer + 2) = InPadTop;

				*(bool*)(__InBuffer + 3) = InPadBottom;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSidesToPad, __InBuffer);
			}
		}

		private static uint __PadLeft = 0;

		private static uint __PadRight = 0;

		private static uint __PadTop = 0;

		private static uint __PadBottom = 0;

		private static uint __SetSidesToPad = 0;
	}
}