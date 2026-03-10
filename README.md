# Random Password Generator - Specification Document

## 1. Project Overview

- **Project Name**: PasswordGenerator
- **Project Type**: Windows Desktop Application (WinForms)
- **Core Functionality**: Generate random passwords with customizable rules and save history for viewing
- **Target Users**: General users who need to generate secure passwords

## 2. UI/UX Specification

### 2.1 Layout Structure

**Main Window (Single Form)**

- Size: 500x600 pixels (resizable, minimum 450x500)
- Title: "随机密码生成器"
- Layout: Vertical stack with three main sections

**Sections**:

1. **Password Display Area** (Top) - Shows generated password
2. **Settings Area** (Middle) - Password rules and length
3. **History Area** (Bottom) - List of saved passwords

### 2.2 Visual Design

**Color Palette**:

- Primary Background: #1E1E2E (Dark charcoal)
- Secondary Background: #2D2D44 (Slate blue-gray)
- Accent Color: #7C3AED (Vibrant purple)
- Text Primary: #F8F8F2 (Off-white)
- Text Secondary: #A0A0B0 (Muted gray)
- Success: #10B981 (Emerald green)
- Border: #3D3D5C (Subtle purple-gray)

**Typography**:

- Font Family: Segoe UI
- Password Display: 18pt, Bold
- Labels: 10pt, Regular
- Buttons: 10pt, SemiBold
- History Items: 9pt, Regular

**Spacing**:

- Section Padding: 16px
- Element Margin: 8px
- Button Padding: 12px horizontal, 8px vertical

**Visual Effects**:

- Rounded corners: 8px for panels, 6px for buttons
- Subtle shadow on password display panel
- Hover effects on buttons (lighten by 10%)

### 2.3 Components

**Password Display Panel**:

- Large text box showing generated password (read-only)
- Copy button on the right side
- Regenerate button below

**Settings Panel**:

- Length slider (8-64, default 16) with numeric display
- Checkboxes for character types:
  - ✓ 大写字母 (A-Z)
  - ✓ 小写字母 (a-z)
  - ✓ 数字 (0-9)
  - ✓ 特殊字符 (!@#$%^&*...)
- At least one character type must be selected

**Action Buttons**:

- "生成密码" (Generate) - Primary accent button
- "保存密码" (Save) - Secondary button

**History Panel**:

- ListView with columns: Time, Password, Length, Rules
- Double-click to copy
- Delete button for selected item
- Clear all button

## 3. Functional Specification

### 3.1 Core Features

1. **Password Generation**
   - Generate random passwords based on selected rules
   - Length range: 8-64 characters
   - Character sets:
     - Uppercase: ABCDEFGHIJKLMNOPQRSTUVWXYZ
     - Lowercase: abcdefghijklmnopqrstuvwxyz
     - Digits: 0123456789
     - Special: !@#$%^&*()_+-=[]{}|;:,.<>?

2. **Password Display**
   - Show generated password in large, readable font
   - One-click copy to clipboard
   - Visual feedback on copy (brief color change)

3. **History Management**
   - Auto-save generated passwords with timestamp
   - Display history in chronological order (newest first)
   - Store: timestamp, password, length, rules used
   - Delete individual entries
   - Clear all history
   - Persist history to JSON file

4. **Data Persistence**
   - Save location: %APPDATA%\PasswordGenerator\history.json
   - Format: JSON array of password records
   - Load history on startup
   - Save after each password generation

### 3.2 User Interactions

1. Adjust length via slider or numeric input
2. Toggle character type checkboxes
3. Click "生成密码" to create new password
4. Click "复制" to copy current password
5. Click "保存" to save current password to history
6. Double-click history item to copy
7. Select and delete history items

### 3.3 Edge Cases

- Prevent generation if no character types selected (show warning)
- Handle corrupted history file gracefully
- Validate password length bounds
- Prevent duplicate consecutive passwords

## 4. Acceptance Criteria

### 4.1 Success Conditions

- [ ] Application launches without errors
- [ ] Password length slider works (8-64 range)
- [ ] All four character type checkboxes work
- [ ] At least one character type must be selected
- [ ] Generated password matches selected rules
- [ ] Copy to clipboard works
- [ ] Password saves to history automatically
- [ ] History persists between sessions
- [ ] History items can be deleted
- [ ] All UI elements are visible and functional

### 4.2 Visual Checkpoints

- Dark theme applied consistently
- Password text is large and readable
- Buttons have hover effects
- History list is scrollable
- Form is resizable with proper scaling
