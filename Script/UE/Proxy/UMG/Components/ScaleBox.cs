using Script.CoreUObject;
using Script.Slate;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.ScaleBox")]
	public partial class UScaleBox : UContentWidget, IStaticClass
	{
		public EStretch Stretch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Stretch, __ReturnBuffer);

					return *(EStretch*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Stretch, __InBuffer);
				}
			}
		}

		public EStretchDirection StretchDirection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StretchDirection, __ReturnBuffer);

					return *(EStretchDirection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StretchDirection, __InBuffer);
				}
			}
		}

		public float UserSpecifiedScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserSpecifiedScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserSpecifiedScale, __InBuffer);
				}
			}
		}

		public bool IgnoreInheritedScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IgnoreInheritedScale, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IgnoreInheritedScale, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.ScaleBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetUserSpecifiedScale(float InUserSpecifiedScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InUserSpecifiedScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUserSpecifiedScale, __InBuffer);
			}
		}

		public virtual void SetStretchDirection(EStretchDirection InStretchDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InStretchDirection;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStretchDirection, __InBuffer);
			}
		}

		public virtual void SetStretch(EStretch InStretch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InStretch;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStretch, __InBuffer);
			}
		}

		public virtual void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInIgnoreInheritedScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIgnoreInheritedScale, __InBuffer);
			}
		}

		private static uint __Stretch = 0;

		private static uint __StretchDirection = 0;

		private static uint __UserSpecifiedScale = 0;

		private static uint __IgnoreInheritedScale = 0;

		private static uint __SetUserSpecifiedScale = 0;

		private static uint __SetStretchDirection = 0;

		private static uint __SetStretch = 0;

		private static uint __SetIgnoreInheritedScale = 0;
	}
}