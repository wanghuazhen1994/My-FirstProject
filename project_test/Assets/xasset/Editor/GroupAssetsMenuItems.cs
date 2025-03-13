using UnityEngine;
using UnityEditor;
namespace xasset.editor
{
	public static class GroupAssetsMenuItems
	{
		[MenuItem("Assets/Group To/MyBuilder/Prefabs")]
		private static void GroupToMyBuilderPrefabs()
		{
			Settings.MakeSelectionAssetsGroupTo("MyBuilder", "Prefabs");
			Debug.Log("Group to Prefabs with build MyBuilder.");
		}

		[MenuItem("Assets/Group To/MyBuilder/EnterScenes")]
		private static void GroupToMyBuilderEnterScenes()
		{
			Settings.MakeSelectionAssetsGroupTo("MyBuilder", "EnterScenes");
			Debug.Log("Group to EnterScenes with build MyBuilder.");
		}
	}
}
