using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.AssetActionUtility")]
	public partial class UAssetActionUtility : UEditorUtilityObject, IStaticClass, IEditorUtilityExtension
	{
		public TArray<TSoftClassPtr<UObject>> SupportedClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedClasses, __ReturnBuffer);

					return *(TArray<TSoftClassPtr<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedClasses, __InBuffer);
				}
			}
		}

		public TArray<FAssetActionSupportCondition> SupportedConditions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedConditions, __ReturnBuffer);

					return *(TArray<FAssetActionSupportCondition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedConditions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.AssetActionUtility");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual bool IsActionForBlueprints()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall1Implementation(GarbageCollectionHandle, __IsActionForBlueprints, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<TSoftClassPtr<UObject>> GetSupportedClasses()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSupportedClasses, __ReturnBuffer);

				return *(TArray<TSoftClassPtr<UObject>>*)__ReturnBuffer;
			}
		}

		public virtual UClass GetSupportedClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall1Implementation(GarbageCollectionHandle, __GetSupportedClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		private static uint __SupportedClasses = 0;

		private static uint __SupportedConditions = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __IsActionForBlueprints = 0;

		private static uint __GetSupportedClasses = 0;

		private static uint __GetSupportedClass = 0;
	}
}