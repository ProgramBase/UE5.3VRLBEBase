using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.CircularThrobber")]
	public partial class UCircularThrobber : UWidget, IStaticClass
	{
		public int NumberOfPieces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumberOfPieces, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumberOfPieces, __InBuffer);
				}
			}
		}

		public float Period
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Period, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Period, __InBuffer);
				}
			}
		}

		public float Radius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Radius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Radius, __InBuffer);
				}
			}
		}

		public FSlateBrush Image
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Image, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Image, __InBuffer);
				}
			}
		}

		public bool bEnableRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRadius, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRadius, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.CircularThrobber");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetRadius(float InRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InRadius;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRadius, __InBuffer);
			}
		}

		public virtual void SetPeriod(float InPeriod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InPeriod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPeriod, __InBuffer);
			}
		}

		public virtual void SetNumberOfPieces(int InNumberOfPieces)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InNumberOfPieces;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNumberOfPieces, __InBuffer);
			}
		}

		private static uint __NumberOfPieces = 0;

		private static uint __Period = 0;

		private static uint __Radius = 0;

		private static uint __Image = 0;

		private static uint __bEnableRadius = 0;

		private static uint __SetRadius = 0;

		private static uint __SetPeriod = 0;

		private static uint __SetNumberOfPieces = 0;
	}
}