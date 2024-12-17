using Script.CoreUObject;
using Script.Library;

namespace Script.UndoHistoryEditor
{
	[PathName("/Script/UndoHistoryEditor.UndoHistorySettings")]
	public partial class UUndoHistorySettings : UObject, IStaticClass
	{
		public bool bShowTransactionDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowTransactionDetails, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowTransactionDetails, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UndoHistoryEditor.UndoHistorySettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bShowTransactionDetails = 0;
	}
}