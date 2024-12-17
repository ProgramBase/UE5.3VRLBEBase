using Script.CoreUObject;
using Script.IKRig;
using Script.Library;
using Script.Engine;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRigController")]
	public partial class UIKRigController : UObject, IStaticClass
	{
		public UIKRigDefinition Asset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Asset, __ReturnBuffer);

					return *(UIKRigDefinition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Asset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRigController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetSolverEnabled(int SolverIndex, bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = SolverIndex;

				*(bool*)(__InBuffer + 4) = bIsEnabled;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSolverEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetSkeletalMesh(USkeletalMesh SkeletalMesh, bool bTransact = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSkeletalMesh, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetRootBone(FName RootBoneName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = RootBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRootBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetRetargetRoot(FName RootBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RootBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRetargetRoot, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetRetargetChainStartBone(FName ChainName, FName StartBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StartBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRetargetChainStartBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetRetargetChainGoal(FName ChainName, FName GoalName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRetargetChainGoal, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetRetargetChainEndBone(FName ChainName, FName EndBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = EndBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetRetargetChainEndBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetGoalBone(FName GoalName, FName NewBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetGoalBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetEndBone(FName EndBoneName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = EndBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetEndBone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetBoneExcluded(FName BoneName, bool bExclude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bExclude;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBoneExcluded, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName RenameRetargetChain(FName ChainName, FName NewChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __RenameRetargetChain, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FName RenameGoal(FName OldName, FName PotentialNewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OldName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PotentialNewName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __RenameGoal, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveSolver(int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveSolver, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveRetargetChain(FName ChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveRetargetChain, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveGoal(FName GoalName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveGoal, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveBoneSetting(FName BoneName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveBoneSetting, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool MoveSolverInStack(int SolverToMoveIndex, int TargetSolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = SolverToMoveIndex;

				*(int*)(__InBuffer + 4) = TargetSolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MoveSolverInStack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSkeletalMeshCompatible(USkeletalMesh SkeletalMeshToCheck)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SkeletalMeshToCheck?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSkeletalMeshCompatible, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsGoalConnectedToSolver(FName GoalName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsGoalConnectedToSolver, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsGoalConnectedToAnySolver(FName GoalName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsGoalConnectedToAnySolver, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetSolverEnabled(int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSolverEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UIKRigSolver GetSolverAtIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSolverAtIndex, __InBuffer, __ReturnBuffer);

				return *(UIKRigSolver*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMesh GetSkeletalMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkeletalMesh, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		public virtual FName GetRootBone(int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRootBone, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FName GetRetargetRoot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRetargetRoot, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FName GetRetargetChainStartBone(FName ChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRetargetChainStartBone, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual TArray<FBoneChain> GetRetargetChains()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRetargetChains, __ReturnBuffer);

				return *(TArray<FBoneChain>*)__ReturnBuffer;
			}
		}

		public virtual FName GetRetargetChainGoal(FName ChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRetargetChainGoal, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FName GetRetargetChainEndBone(FName ChainName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRetargetChainEndBone, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetRefPoseTransformOfBone(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRefPoseTransformOfBone, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual int GetNumSolvers()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumSolvers, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetIndexOfSolver(UIKRigSolver Solver)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Solver?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetIndexOfSolver, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UObject GetGoalSettingsForSolver(FName GoalName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGoalSettingsForSolver, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual FName GetGoalNameForBone(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGoalNameForBone, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual UIKRigEffectorGoal GetGoal(FName GoalName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetGoal, __InBuffer, __ReturnBuffer);

				return *(UIKRigEffectorGoal*)__ReturnBuffer;
			}
		}

		public virtual FName GetEndBone(int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetEndBone, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static UIKRigController GetController(UIKRigDefinition InIKRigDefinition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InIKRigDefinition?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetController, __InBuffer, __ReturnBuffer);

				return *(UIKRigController*)__ReturnBuffer;
			}
		}

		public virtual UObject GetBoneSettings(FName BoneName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneSettings, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual FName GetBoneForGoal(FName GoalName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneForGoal, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual bool GetBoneExcluded(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBoneExcluded, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<UIKRigEffectorGoal> GetAllGoals()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllGoals, __ReturnBuffer);

				return *(TArray<UIKRigEffectorGoal>*)__ReturnBuffer;
			}
		}

		public virtual bool DisconnectGoalFromSolver(FName GoalToRemove, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = GoalToRemove?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DisconnectGoalFromSolver, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ConnectGoalToSolver(FName GoalName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ConnectGoalToSolver, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int AddSolver(TSubclassOf<UIKRigSolver> InSolverClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSolverClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSolver, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FName AddRetargetChain(FName ChainName, FName StartBoneName, FName EndBoneName, FName GoalName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = ChainName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StartBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EndBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddRetargetChain, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual FName AddNewGoal(FName GoalName, FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = GoalName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddNewGoal, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual bool AddBoneSetting(FName BoneName, int SolverIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SolverIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddBoneSetting, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Asset = 0;

		private static uint __SetSolverEnabled = 0;

		private static uint __SetSkeletalMesh = 0;

		private static uint __SetRootBone = 0;

		private static uint __SetRetargetRoot = 0;

		private static uint __SetRetargetChainStartBone = 0;

		private static uint __SetRetargetChainGoal = 0;

		private static uint __SetRetargetChainEndBone = 0;

		private static uint __SetGoalBone = 0;

		private static uint __SetEndBone = 0;

		private static uint __SetBoneExcluded = 0;

		private static uint __RenameRetargetChain = 0;

		private static uint __RenameGoal = 0;

		private static uint __RemoveSolver = 0;

		private static uint __RemoveRetargetChain = 0;

		private static uint __RemoveGoal = 0;

		private static uint __RemoveBoneSetting = 0;

		private static uint __MoveSolverInStack = 0;

		private static uint __IsSkeletalMeshCompatible = 0;

		private static uint __IsGoalConnectedToSolver = 0;

		private static uint __IsGoalConnectedToAnySolver = 0;

		private static uint __GetSolverEnabled = 0;

		private static uint __GetSolverAtIndex = 0;

		private static uint __GetSkeletalMesh = 0;

		private static uint __GetRootBone = 0;

		private static uint __GetRetargetRoot = 0;

		private static uint __GetRetargetChainStartBone = 0;

		private static uint __GetRetargetChains = 0;

		private static uint __GetRetargetChainGoal = 0;

		private static uint __GetRetargetChainEndBone = 0;

		private static uint __GetRefPoseTransformOfBone = 0;

		private static uint __GetNumSolvers = 0;

		private static uint __GetIndexOfSolver = 0;

		private static uint __GetGoalSettingsForSolver = 0;

		private static uint __GetGoalNameForBone = 0;

		private static uint __GetGoal = 0;

		private static uint __GetEndBone = 0;

		private static uint __GetController = 0;

		private static uint __GetBoneSettings = 0;

		private static uint __GetBoneForGoal = 0;

		private static uint __GetBoneExcluded = 0;

		private static uint __GetAllGoals = 0;

		private static uint __DisconnectGoalFromSolver = 0;

		private static uint __ConnectGoalToSolver = 0;

		private static uint __AddSolver = 0;

		private static uint __AddRetargetChain = 0;

		private static uint __AddNewGoal = 0;

		private static uint __AddBoneSetting = 0;
	}
}