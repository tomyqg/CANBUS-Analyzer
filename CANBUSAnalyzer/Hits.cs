﻿using System;
using System.IO;

namespace CANBUS
{
  class Hits {
    public string path { get { return _path; } }
    public string filename { get { return _filename; } }
    private string _path;
    private string _filename;

    public Hits(string path, string filename) {
      this._path = path;
      try {
        this._filename = Path.GetFileName(filename);
      }
      catch (Exception) { this._filename = filename; };
    }

  }
}
