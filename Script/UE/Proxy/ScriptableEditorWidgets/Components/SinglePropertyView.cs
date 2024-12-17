using Script.CoreUObject;
using Script.Library;

namespace Script.ScriptableEditorWidgets
{
	[PathName("/Script/ScriptableEditorWidgets.SinglePropertyView")]
	public partial class USinglePropertyView : UPropertyViewBase, IStaticClass
	{
		public FName PropertyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyName, __InBuffer);
				}
			}
		}

		public FText NameOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NameOverride, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NameOverride, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ScriptableEditorWidgets.SinglePropertyView");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetPropertyName(FName NewPropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPropertyName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPropertyName, __InBuffer);
			}
		}

		public virtual void SetNameOverride(FText NewPropertyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPropertyName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNameOverride, __InBuffer);
			}
		}

		public virtual FName GetPropertyName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPropertyName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FText GetNameOverride()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNameOverride, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		private static uint __PropertyName = 0;

		private static uint __NameOverride = 0;

		private static uint __SetPropertyName = 0;

		private static uint __SetNameOverride = 0;

		private static uint __GetPropertyName = 0;

		private static uint __GetNameOverride = 0;
	}
}