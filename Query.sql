SELECT DISTINCT e.record_id, e.element_id, e.text, f.filename
FROM omeka_element_texts e, omeka_files f
WHERE e.record_id = f.item_id AND e.record_id = ANY (SELECT record_id FROM omeka_tags t JOIN omeka_records_tags r ON t.id = r.tag_id WHERE t.id = 1044);
