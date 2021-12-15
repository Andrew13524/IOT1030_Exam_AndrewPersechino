using Assets.Scripts.GameObjects;
using Assets.Scripts.GameObjects.Scenes;
using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongTemplatePrefab : MonoBehaviour
{
    public Song Song = new Song();

    public void OnClick()
    {
        var notes = new Queue<Note>();
        foreach (Note note in Song.Notes)
        {
            notes.Enqueue(note);
        }
        Song copy = new Song(Song.Title, Song.Artist, Song.AudioClip, notes);
        Menu.LoadNoteHighway(copy, NoteHighwayState.PLAY);
    }
}
