using Script.CoreUObject;
using Script.Reflection.Property;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimClassData")]
	public partial class UAnimClassData : UObject, IStaticClass, IAnimClassInterface
	{
		public TArray<FBakedAnimationStateMachine> BakedStateMachines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BakedStateMachines, __ReturnBuffer);

					return *(TArray<FBakedAnimationStateMachine>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BakedStateMachines, __InBuffer);
				}
			}
		}

		public USkeleton TargetSkeleton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetSkeleton, __ReturnBuffer);

					return *(USkeleton*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetSkeleton, __InBuffer);
				}
			}
		}

		public TArray<FAnimNotifyEvent> AnimNotifies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimNotifies, __ReturnBuffer);

					return *(TArray<FAnimNotifyEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimNotifies, __InBuffer);
				}
			}
		}

		public TMap<FName, FCachedPoseIndices> OrderedSavedPoseIndicesMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OrderedSavedPoseIndicesMap, __ReturnBuffer);

					return *(TMap<FName, FCachedPoseIndices>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OrderedSavedPoseIndicesMap, __InBuffer);
				}
			}
		}

		public TArray<FAnimBlueprintFunction> AnimBlueprintFunctions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlueprintFunctions, __ReturnBuffer);

					return *(TArray<FAnimBlueprintFunction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlueprintFunctions, __InBuffer);
				}
			}
		}

		public TArray<FAnimBlueprintFunctionData> AnimBlueprintFunctionData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlueprintFunctionData, __ReturnBuffer);

					return *(TArray<FAnimBlueprintFunctionData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlueprintFunctionData, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> AnimNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimNodeProperties, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> LinkedAnimGraphNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedAnimGraphNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedAnimGraphNodeProperties, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> LinkedAnimLayerNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedAnimLayerNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedAnimLayerNodeProperties, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> PreUpdateNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreUpdateNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreUpdateNodeProperties, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> DynamicResetNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicResetNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicResetNodeProperties, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> StateMachineNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StateMachineNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StateMachineNodeProperties, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> InitializationNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitializationNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitializationNodeProperties, __InBuffer);
				}
			}
		}

		public TMap<FName, FGraphAssetPlayerInformation> GraphNameAssetPlayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GraphNameAssetPlayers, __ReturnBuffer);

					return *(TMap<FName, FGraphAssetPlayerInformation>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GraphNameAssetPlayers, __InBuffer);
				}
			}
		}

		public TArray<FName> SyncGroupNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SyncGroupNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SyncGroupNames, __InBuffer);
				}
			}
		}

		public TMap<FName, FAnimGraphBlendOptions> GraphBlendOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GraphBlendOptions, __ReturnBuffer);

					return *(TMap<FName, FAnimGraphBlendOptions>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GraphBlendOptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimClassData");
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

		private static uint __BakedStateMachines = 0;

		private static uint __TargetSkeleton = 0;

		private static uint __AnimNotifies = 0;

		private static uint __OrderedSavedPoseIndicesMap = 0;

		private static uint __AnimBlueprintFunctions = 0;

		private static uint __AnimBlueprintFunctionData = 0;

		private static uint __AnimNodeProperties = 0;

		private static uint __LinkedAnimGraphNodeProperties = 0;

		private static uint __LinkedAnimLayerNodeProperties = 0;

		private static uint __PreUpdateNodeProperties = 0;

		private static uint __DynamicResetNodeProperties = 0;

		private static uint __StateMachineNodeProperties = 0;

		private static uint __InitializationNodeProperties = 0;

		private static uint __GraphNameAssetPlayers = 0;

		private static uint __SyncGroupNames = 0;

		private static uint __GraphBlendOptions = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}