﻿using Script.CoreUObject;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.ERigVMGraphNotifType")]
	public enum ERigVMGraphNotifType : byte
	{
		GraphChanged = 0,
		NodeAdded = 1,
		NodeRemoved = 2,
		NodeSelected = 3,
		NodeDeselected = 4,
		NodeSelectionChanged = 5,
		NodePositionChanged = 6,
		NodeSizeChanged = 7,
		NodeColorChanged = 8,
		PinAdded = 9,
		PinRemoved = 10,
		PinRenamed = 11,
		PinExpansionChanged = 12,
		PinWatchedChanged = 13,
		PinArraySizeChanged = 14,
		PinDefaultValueChanged = 15,
		PinDirectionChanged = 16,
		PinTypeChanged = 17,
		PinIndexChanged = 18,
		LinkAdded = 19,
		LinkRemoved = 20,
		CommentTextChanged = 21,
		VariableAdded = 22,
		VariableRemoved = 23,
		VariableRenamed = 24,
		InteractionBracketOpened = 25,
		InteractionBracketClosed = 26,
		InteractionBracketCanceled = 27,
		PinBoundVariableChanged = 28,
		NodeRenamed = 29,
		NodeReferenceChanged = 30,
		NodeCategoryChanged = 31,
		NodeKeywordsChanged = 32,
		NodeDescriptionChanged = 33,
		VariableRemappingChanged = 34,
		LibraryTemplateChanged = 35,
		FunctionAccessChanged = 36,
		Invalid = 37,
	}
}