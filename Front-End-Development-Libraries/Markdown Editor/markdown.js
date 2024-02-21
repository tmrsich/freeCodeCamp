document.addEventListener('DOMContentLoaded', function () {
    const editor = document.getElementById('editor');
    const preview = document.getElementById('preview');
  
    // Set default markdown content
    const defaultMarkdown = `# Heading 1
  ## Heading 2
  [Visit Google](https://www.google.com)
  \`inline code\`
  \`\`\`
  // Code block
  const message = 'Hello, World!';
  console.log(message);
  \`\`\`
  - List item 1
  - List item 2
  > Blockquote
  ![Image](https://placekitten.com/200/150)
  **Bolded Text**`;
  
    // Initialize editor with default markdown
    editor.value = defaultMarkdown;
    updatePreview();
  
    // Add input event listener to the editor
    editor.addEventListener('input', updatePreview);
  
    // Function to update the preview with marked library
    function updatePreview() {
      const markdown = editor.value;
      const html = marked(markdown);
      preview.innerHTML = html;
    }
  });
  