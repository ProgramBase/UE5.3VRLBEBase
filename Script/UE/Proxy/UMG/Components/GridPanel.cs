using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.GridPanel")]
	public partial class UGridPanel : UPanelWidget, IStaticClass
	{
		public TArray<float> ColumnFill
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColumnFill, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColumnFill, __InBuffer);
				}
			}
		}

		public TArray<float> RowFill
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RowFill, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RowFill, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.GridPanel");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetRowFill(int RowIndex, float Coefficient)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = RowIndex;

				*(float*)(__InBuffer + 4) = Coefficient;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRowFill, __InBuffer);
			}
		}

		public virtual void SetColumnFill(int ColumnIndex, float Coefficient)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = ColumnIndex;

				*(float*)(__InBuffer + 4) = Coefficient;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColumnFill, __InBuffer);
			}
		}

		public virtual UGridSlot AddChildToGrid(UWidget Content, int InRow = 0, int InColumn = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InRow;

				*(int*)(__InBuffer + 12) = InColumn;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddChildToGrid, __InBuffer, __ReturnBuffer);

				return *(UGridSlot*)__ReturnBuffer;
			}
		}

		private static uint __ColumnFill = 0;

		private static uint __RowFill = 0;

		private static uint __SetRowFill = 0;

		private static uint __SetColumnFill = 0;

		private static uint __AddChildToGrid = 0;
	}
}