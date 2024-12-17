using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.ModelingComponents;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.SkeletalMeshToolTarget")]
	public partial class USkeletalMeshToolTarget : USkeletalMeshReadOnlyToolTarget, IStaticClass, IMeshDescriptionCommitter, IDynamicMeshCommitter
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.SkeletalMeshToolTarget");
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

		private static uint __ExecuteUbergraph = 0;
	}
}