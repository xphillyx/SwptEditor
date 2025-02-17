﻿// Copyright 2021 Crystal Ferrai
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SwptSaveEditor.Input;
using SwptSaveEditor.Undo;
using System.Collections.Generic;

namespace SwptSaveEditor.Document
{
    /// <summary>
    /// Interface for a document, which represents the top level content of a tab in the editor
    /// </summary>
    internal interface IDocument
    {
        /// <summary>
        /// The name of the document
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Input actions defined by the document for the input service to process
        /// </summary>
        IEnumerable<InputAction> InputActions { get; }

        /// <summary>
        /// Gets an undo service associated with the document
        /// </summary>
        IUndoService UndoService { get; }
    }
}
